BMI_CONSTANT = 703
weight = float(input("Input the subject's weight in punds: "))
height = float(input("Input the subject's height in inches: "))

bmi = weight*(BMI_CONSTANT/(height**2))

if bmi >= 18.8 and bmi <= 25:
    print('The subject is in the healthy range of BMI values.')
else:
    if bmi > 25:
        print('The subject is overweight, according to their BMI.')
    else:
        print('The subject in underweight, according to their BMI.') 
