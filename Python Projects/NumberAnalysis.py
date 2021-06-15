numlist = [0] * 5

def populateList():
    index = 0
    while index < len(numlist):
        print('Input value for index ', index, ':', sep='')
        numlist[index] = int(input())
        index += 1

def total(list):
    templist = list
    total = 0
    index = 0
    while index < len(templist):
        total += templist[index]
        index += 1

    return total    

def average(list):
    templist = list
    avg = 0
    index = 0
    while index < len(templist):
        avg += templist[index]
        index += 1

    avg = avg / len(templist)

    return avg


def main():
    populateList()
    print('The lowest value in the list is :', min(numlist))
    print('The highest value in the list is:', max(numlist))
    print('The total of the numbers in the list is:', total(numlist))
    print('The average of the values in the list are:', average(numlist))

main()        