
namespace PasswordGenerator
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblGenerated = new System.Windows.Forms.Label();
            this.tbGenerated = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbLower = new System.Windows.Forms.CheckBox();
            this.cbCapital = new System.Windows.Forms.CheckBox();
            this.cbNumber = new System.Windows.Forms.CheckBox();
            this.cbChars = new System.Windows.Forms.CheckBox();
            this.cbCheckSecurity = new System.Windows.Forms.CheckBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.nudPassLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.timerChecks = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLength)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGenerated
            // 
            this.lblGenerated.AutoSize = true;
            this.lblGenerated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerated.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGenerated.Location = new System.Drawing.Point(9, 44);
            this.lblGenerated.Name = "lblGenerated";
            this.lblGenerated.Size = new System.Drawing.Size(162, 20);
            this.lblGenerated.TabIndex = 2;
            this.lblGenerated.Text = "Generated password:";
            // 
            // tbGenerated
            // 
            this.tbGenerated.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGenerated.Location = new System.Drawing.Point(13, 67);
            this.tbGenerated.Name = "tbGenerated";
            this.tbGenerated.PasswordChar = '*';
            this.tbGenerated.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbGenerated.Size = new System.Drawing.Size(248, 29);
            this.tbGenerated.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.Location = new System.Drawing.Point(13, 269);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(248, 37);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cbLower
            // 
            this.cbLower.AutoSize = true;
            this.cbLower.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cbLower.Location = new System.Drawing.Point(16, 212);
            this.cbLower.Name = "cbLower";
            this.cbLower.Size = new System.Drawing.Size(78, 17);
            this.cbLower.TabIndex = 5;
            this.cbLower.Text = "Lowercase";
            this.cbLower.UseVisualStyleBackColor = true;
            // 
            // cbCapital
            // 
            this.cbCapital.AutoSize = true;
            this.cbCapital.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cbCapital.Location = new System.Drawing.Point(100, 212);
            this.cbCapital.Name = "cbCapital";
            this.cbCapital.Size = new System.Drawing.Size(89, 17);
            this.cbCapital.TabIndex = 6;
            this.cbCapital.Text = "Capital letters";
            this.cbCapital.UseVisualStyleBackColor = true;
            // 
            // cbNumber
            // 
            this.cbNumber.AutoSize = true;
            this.cbNumber.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cbNumber.Location = new System.Drawing.Point(195, 212);
            this.cbNumber.Name = "cbNumber";
            this.cbNumber.Size = new System.Drawing.Size(68, 17);
            this.cbNumber.TabIndex = 7;
            this.cbNumber.Text = "Numbers";
            this.cbNumber.UseVisualStyleBackColor = true;
            // 
            // cbChars
            // 
            this.cbChars.AutoSize = true;
            this.cbChars.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cbChars.Location = new System.Drawing.Point(17, 235);
            this.cbChars.Name = "cbChars";
            this.cbChars.Size = new System.Drawing.Size(77, 17);
            this.cbChars.TabIndex = 8;
            this.cbChars.Text = "Characters";
            this.cbChars.UseVisualStyleBackColor = true;
            // 
            // cbCheckSecurity
            // 
            this.cbCheckSecurity.AutoSize = true;
            this.cbCheckSecurity.ForeColor = System.Drawing.Color.Red;
            this.cbCheckSecurity.Location = new System.Drawing.Point(100, 235);
            this.cbCheckSecurity.Name = "cbCheckSecurity";
            this.cbCheckSecurity.Size = new System.Drawing.Size(96, 17);
            this.cbCheckSecurity.TabIndex = 9;
            this.cbCheckSecurity.Text = "Check security";
            this.cbCheckSecurity.UseVisualStyleBackColor = true;
            this.cbCheckSecurity.CheckedChanged += new System.EventHandler(this.cbCheckSecurity_CheckedChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(36, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(208, 25);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Password Generator";
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSettings.Location = new System.Drawing.Point(12, 180);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(68, 20);
            this.lblSettings.TabIndex = 11;
            this.lblSettings.Text = "Settings";
            // 
            // tbConsole
            // 
            this.tbConsole.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConsole.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbConsole.Location = new System.Drawing.Point(14, 329);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConsole.Size = new System.Drawing.Size(243, 134);
            this.tbConsole.TabIndex = 12;
            // 
            // nudPassLength
            // 
            this.nudPassLength.Location = new System.Drawing.Point(161, 143);
            this.nudPassLength.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudPassLength.Name = "nudPassLength";
            this.nudPassLength.Size = new System.Drawing.Size(102, 20);
            this.nudPassLength.TabIndex = 13;
            this.nudPassLength.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Password length:";
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cbShowPass.Location = new System.Drawing.Point(161, 99);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(101, 17);
            this.cbShowPass.TabIndex = 15;
            this.cbShowPass.Text = "Show password";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // timerChecks
            // 
            this.timerChecks.Enabled = true;
            this.timerChecks.Interval = 500;
            this.timerChecks.Tick += new System.EventHandler(this.timerChecks_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(269, 475);
            this.Controls.Add(this.cbShowPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPassLength);
            this.Controls.Add(this.tbConsole);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbCheckSecurity);
            this.Controls.Add(this.cbChars);
            this.Controls.Add(this.cbNumber);
            this.Controls.Add(this.cbCapital);
            this.Controls.Add(this.cbLower);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbGenerated);
            this.Controls.Add(this.lblGenerated);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGenerated;
        private System.Windows.Forms.TextBox tbGenerated;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox cbLower;
        private System.Windows.Forms.CheckBox cbCapital;
        private System.Windows.Forms.CheckBox cbNumber;
        private System.Windows.Forms.CheckBox cbChars;
        private System.Windows.Forms.CheckBox cbCheckSecurity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.TextBox tbConsole;
        private System.Windows.Forms.NumericUpDown nudPassLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbShowPass;
        private System.Windows.Forms.Timer timerChecks;
    }
}

