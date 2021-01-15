import math
One=0
Two=0
Three=0
Four=0
Count=0
x=0
n=0

for Count in range(1,6):
    number = int(input("Enter Number: "))

    x = int(math.log10(number))+1
    if x == 1: One=One+1
    if x == 2: Two=Two+1
    if x == 3: Three=Three+1
    if x ==  4: Four=Four+1
    if x > 4: n=n+1

Per=(n/5)*100
print(One,Two,Three,Four,Per)