import requests
import hashlib
import sys

def request_api_data(query_char):
    url = 'https://api.pwnedpasswords.com/range/' + query_char

    res = requests.get(url)
    if res.status_code != 200:
        print("Error establishing the network connection")
        #raise RuntimeError(r'Error fetchning: {res.status_code}. Check the API')
    return res

def get_password_leaks_count(hashes, hash_to_check):
    hashes = (line.split(':') for line in hashes.text.splitlines())
    for h, count in hashes:
        if h == hash_to_check:
            return count
    return 0

def pwned_api_check(password):
    sha1password = hashlib.sha1(password.encode('utf-8')).hexdigest().upper()
    first_5, tail = sha1password[:5], sha1password[5:]
    response = request_api_data(first_5)
    return get_password_leaks_count(response, tail)



def main(args):
    if len(args) == 0:
        args = "sejtnyryjhb se"
        count = pwned_api_check(args)
        if count:
            print(f'{args} found {count} time, it\'s better to change it...')
        else:
            print('All safe')
        return "Done"
    else:
        for password in args:
            count = pwned_api_check(password)
            if count:
                print(f'{password} found {count} time, it\'s better to change it...')
            else:
                print('All safe')
        return 'Done'
       

main(sys.argv[1:])
# os.system("pause")