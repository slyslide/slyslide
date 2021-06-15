def main():
    print('Input a string of characters to analyse:')
    inputstring = input()
    print('Number of vowels:', vowelCounter(inputstring))
    print('Number of consonants:', conCounter(inputstring))

def vowelCounter(string):
    index = 0
    vowels = 0

    while index < len(string.lower()):
        if (string[index] == 'a' or string[index] == 'e' or 
        string[index] == 'i' or string[index] == 'o' or string[index] == 'u'):
            vowels += 1
            index += 1
        else:
            index += 1
    
    return vowels

def conCounter(string):
    index = 0
    cons = 0
    

    while index < len(string.lower()):
        if (string[index] == 'a' or string[index] == 'e' or 
        string[index] == 'i' or string[index] == 'o' or string[index] == 'u'):
            index += 1
        else:
            cons += 1
            index += 1
            
    return cons

main()
