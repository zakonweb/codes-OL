import math

a = 0
b = 0
c = 0
d = 0
e = 0

for count in range(10):
    num = int(input())
    x = int(math.log10(num)) + 1
    print(x)
    if x == 1: a = a + 1
    elif x == 2: b = b + 1
    elif x == 3: c = c + 1
    elif x == 4: d = d + 1
    else: e = e + 1
per = (e / 10) * 100
print(a)
print(b)
print(c)
print(d)
print(per)