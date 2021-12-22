using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Main : Form
    {
        const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        const string UPPER_CAES = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBERS = "123456789";
        const string SPECIALS = @"!@£$%^&*()#€";

        public Main()
        {
            InitializeComponent();
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.BackColor = Color.Transparent;
            
            tbConsole.AppendText("Generating...\r\n");

            bool lower = cbLower.Checked;
            bool capital = cbCapital.Checked;
            bool number = cbNumber.Checked;
            bool chars = cbChars.Checked;
            string generated = GeneratePassword(lower, capital, number, chars, Decimal.ToInt32(nudPassLength.Value));
            tbGenerated.Text = generated;

            // FOR DEBUGGING PURPOSES
            //generated = "Iamfree";
            //-------------------------

            if (!cbShowPass.Checked)
                tbConsole.AppendText("Generated: Not showing" + "\r\n");
            else
                tbConsole.AppendText("Generated: " + generated + "\r\n");

            if (cbCheckSecurity.Checked)
            {
                if (generated == "")
                    tbConsole.AppendText("Password length is zero\r\n");

                else
                {
                    int response = pwnedApiCheck(generated);
                    if (response == -1)
                    {
                        tbConsole.AppendText("No connection\r\n");
                        return;
                    }
                    tbConsole.AppendText("Checking security...\r\n");
                    bool isSecure = response == 0 ? true : false;

                    if (cbShowPass.Checked)
                    {
                        if (isSecure)
                        {
                            btnGenerate.BackColor = Color.Lime;
                            tbConsole.AppendText(generated + " is all safe\r\n");
                        }
                        else
                        {
                            btnGenerate.BackColor = Color.Red;
                            tbConsole.AppendText(generated + " was found " + response + " times. Please generate again\r\n");
                        }
                    }

                    else
                    {
                        if (isSecure)
                        {
                            btnGenerate.BackColor = Color.Lime;
                            tbConsole.AppendText("Your password is all safe\r\n");
                        }
                        else
                        {
                            btnGenerate.BackColor = Color.Red;
                            tbConsole.AppendText("This password is not safe. Please generate again\r\n");
                        }
                    }
                }
            }
            tbConsole.AppendText("\r\n");
        }


        public string GeneratePassword(bool useLowercase, bool useUppercase, bool useNumbers, bool useSpecial,
            int passwordSize)
        {
            char[] password = new char[passwordSize];
            string charSet = ""; // Initialise to blank
            System.Random random = new Random();
            int counter;

            // Build up the character set to choose from
            if (useLowercase) charSet += LOWER_CASE;

            if (useUppercase) charSet += UPPER_CAES;

            if (useNumbers) charSet += NUMBERS;

            if (useSpecial) charSet += SPECIALS;

            if (charSet.Length == 0)
                return "";

            for (counter = 0; counter < passwordSize; counter++)
            {
                password[counter] = charSet[random.Next(charSet.Length - 1)];
            }

            return String.Join(null, password);
        }


        private void Main_Load(object sender, EventArgs e)
        {
            cbLower.Checked = true;
            tbGenerated.ReadOnly = true;
            tbConsole.ReadOnly = true;
        }


        private void checkCheckboxes()
        {
            CheckBox[] checks = { cbLower, cbCapital, cbChars, cbNumber };

            foreach (CheckBox c in checks)
            {
                if (c.Checked)
                    c.ForeColor = Color.White;

                else
                    c.ForeColor = Color.Gray;
            }
        }

        private void timerChecks_Tick(object sender, EventArgs e)
        {
            checkCheckboxes();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {

                if (MessageBox.Show(text: "Be sure you are safe :)", caption: "Showing pasword", buttons: MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    tbGenerated.PasswordChar = '\0';
                else
                    cbShowPass.Checked = false;
            }
            else
            {
                tbGenerated.PasswordChar = '*';
            }
        }


        // PASSWORD SECURITY CHECKING AREA
        // ---------------------------------------------------------------------------------------------------------------
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Hashes the input data in sha1. NOTE: this type of encoding is not secure anymore
        static string Hash(string input)
        {
            var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2")));
        }

        // Sends get request to API and gets list of password hashes (html)
        private string requestApiData(string first5)
        {
            string html = string.Empty;
            string url = @"https://api.pwnedpasswords.com/range/" + first5;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            
            request.AutomaticDecompression = DecompressionMethods.GZip;

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())

                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }

                //MessageBox.Show(html);
                return html;
            }
            catch
            {
                return "No value";
            }
        }

        // Takes the response (html) and looks for hash of our password
        private int getCount(string response, string tail)
        {

            string[] hashes = response.Split('\n');

            foreach (string hash in hashes)
            {
                string temp = hash.Split(':')[0];
                if (tail == temp)
                {
                    return Int32.Parse(hash.Split(':')[1]);
                }
            }
            return 0;
        }

        // Takes password as input, hashes it, and returns count using above methods
        private int pwnedApiCheck(string password)
        {
            string sha1password = Hash(password).ToUpper();

            string first_5 = sha1password.Substring(0, 5);

            string tail = sha1password.Substring(5);
            string response = requestApiData(first_5);

            if (response == "No value")
                return -1;
            return getCount(response, tail);
        }

        private void cbCheckSecurity_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCheckSecurity.Checked)
                cbCheckSecurity.ForeColor = Color.Lime;
            else
                cbCheckSecurity.ForeColor = Color.Red;
        }
    }
}