TOTAL_YEARS = int(input('How many years of data would you like to process?'))

month = ['January','February', 'March', 'April', 'May',
'June', 'July', 'August', 'September', 'October', 'November', 'December']

for num in range (TOTAL_YEARS):
    totalrain = 0
    i = 0
    for num in range (12):
        print('Input monthly rainfall in inches for the month of', month[i])
        rain = float(input())
        totalrain += rain
        i += 1
    print('The total rainfall this year was', totalrain, 'inches.')
    print('The average monthly rainfall this year was', totalrain/12 , 'inches per month.')