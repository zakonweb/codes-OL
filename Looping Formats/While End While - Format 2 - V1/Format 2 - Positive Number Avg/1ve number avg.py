Count = 0
Total = 0
largest = -1000

PN = int(input())
while PN != -1:
    Total = Total + PN

    Count = Count + 1
    if PN > largest: largest = PN

    PN = int(input())

Avg = Total / Count
print(Avg)
print(largest)