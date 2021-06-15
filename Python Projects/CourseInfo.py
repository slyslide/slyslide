courseroom = {'CS101' : '3004', 'CS102' : '4501', 'CS103' : '6755',
              'NT110' : '1244', 'CM241' : '1411'}
coursename = {'CS101' : 'Haynes', 'CS102' : 'Alvarado', 'CS103' : 'Rich',
              'NT110' : 'Burke', 'CM241' : 'Lee'}
coursetime = {'CS101' : '8:00am', 'CS102' : '9:00am', 'CS103' : '10:00am',
              'NT110' : '11:00am', 'CM241' : '1:00pm'}

print('Input course code to get course information:')
key = input()

if key in coursename:
    print(courseroom[key])
    print(coursename[key])
    print(coursetime[key])
