print("Compound Interest")
print(" ")
PRINCIPAL = float(input('Input principal investment for calculation: '))
INTEREST_RATE = float((input('Input the interest rate percentage on the account: ')))
INTEREST_RATE = INTEREST_RATE/100
INTEREST_TIME_PERIOD = float(input("Input the rate that interest compouts, in how many times a year it occurs (int): "))
TOTAL_TIME_INVESTED = float(input("How many years will you let the account accrue interest: "))

amount = PRINCIPAL*((1+(INTEREST_RATE/INTEREST_TIME_PERIOD))**(INTEREST_TIME_PERIOD*TOTAL_TIME_INVESTED))
print("The final amount you can withdraw after ", TOTAL_TIME_INVESTED, " years is: ")
print("$", format(amount, ',.2f'), sep='')

