import math

count = 0
number = 0
x = 0
per = 0.0
one=0
two=0
three=0
four=0
n=0

for count in range(1,6):
    number = int(input("Enter a number: "))
    x = int(math.log10(number)) + 1

    if x == 1:
        one = one + 1
    elif x == 2:
        two = two + 1
    elif x == 3:
        three = three + 1
    elif x == 4:
        four = four +1
    else:
        n = n +1

per = (n/2)*100
print(one, two, three, four, n)
