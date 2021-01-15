a = 0
b = 0
low = 1000

for count in range(5):
    temp = int(input())  # input temp

    if temp > 20: a = a + 1
    if temp < 10: b = b + 1
    if temp < low: low = temp
print(">20 =", a)
print("<10 =", b)
print("Lowest =", low)