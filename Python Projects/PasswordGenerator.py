def main():
    print('Please follow the following instructions to generate a new username and password.')
    fname = input('Input your first name:   ')
    lname = input('Input your last name:    ')
    snumber = input('Input your full student number:    ')
    print('Your username is:    ', get_login_name(fname, lname, snumber))
    inputpassword = input('Input your desired password (case sensitive):    ')
    confirmedpassword = confirm_password(inputpassword)
    print('Account created successfully')
    print('Username:    ', get_login_name(fname, lname, snumber))
    print('Password:    ', confirmedpassword)

def get_login_name(firstname, lastname, studentnumber):

    username = firstname[:3] + lastname[:3] + studentnumber[-3:]

    return username

def confirm_password(password):

    while (len(password) < 7) or (passwordloop(password) == 0):
        if len(password) < 7:
            print('Input password must be at least 7 characters long')
            password = input('Please reenter a new password:    ')
        if passwordloop(password) == 0:
            print('Input password must contain one uppercase letter, one lowercase letter,',
            'and one digit.')
            password = input('Please reenter a new password:    ')
        
    return password

def passwordloop(password: str):
    i = upper = lower = digit = 0

    while i < len(password):
        if password[i].isdigit():
            digit += 1
            i += 1
        if password[i].isupper():
            upper += 1
            i += 1
        if password[i].islower():
            lower += 1
            i += 1
        else:
            i += 1
    
    if (digit == 0) or (upper == 0) or (lower == 0):
        return 0
    else:
        return 1



main() 