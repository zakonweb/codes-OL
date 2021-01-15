total = 0
x = []
high = -1000
low = 1000
for i in range(10):
    a = int(input())
    x.append(a)
    total = total + x[i]
    if x[i] > high: high = x[i]
    if x[i] < low: low = x[i]
avg = total / 10
print("Avg=", avg)
print("Highest=", high)
print("Lowest=", low)