#--------------------------------------------------------------------------------
# This program takes a user's inputted banking account information (it's present
# value, the monthly interest rate, and how long they plan on keeping the money
# invested in the account), and outputs the account's future value
#--------------------------------------------------------------------------------
import math

def main():
    futureValueIntro()
    #Get the account's present value
    presentvalue = float(input("Input your account's present cash value:"))
    #Get the account's monthly interest rate, then divides it by 100, for a workable percentage
    monthlyinterest = float(input("Input your account's monthly interest rate," 
    + " as a percentage:"))/100
    #Get the account's total time to accrue interest, in months
    monthsofinterest = int(input("Input the number of months you plan on leaving this account to"
    + " accrue interest (in months):"))
    print()
    #Assigns this variable the return of the futureValueOutput function, to be printed
    accountfuturevalue = futureValueOutput(p=presentvalue, i=monthlyinterest, t=monthsofinterest)
    print("The account's future value is: ")
    #Format's output future value as a dollar amount
    print('$', format(accountfuturevalue, ',.2f'), sep='')

#--------------------------------------------------------------------------------
# The futureValueIntro function provides a simple introductory paragraph, 
# explaining how the program will run
#--------------------------------------------------------------------------------
def futureValueIntro():
    print("This program takes your account's present value, monthly interest rate",
    "and the time period your investment will accrue interest.")
    print("With this information, it will calculate the future value of this account.")
    input('Press enter to begin:')
    print(' ')

#--------------------------------------------------------------------------------
# The futureValueOutput function calculates the future value of an account, with 
# specific user input parameters p=present account value, i=monthly interest
# rate, and t=time the account will accrue interest
#--------------------------------------------------------------------------------    
def futureValueOutput(p, i, t):
    futurevalue = p*math.pow(1+i, t)
    return futurevalue

main()    
