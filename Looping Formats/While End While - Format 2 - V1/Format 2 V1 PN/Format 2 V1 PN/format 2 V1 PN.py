PN = 0
Largest = -1000
Total = 0
Count = -1
AVG = 0

while PN != -1:
    Total = Total + PN
    Count = Count + 1

    if PN > Largest:
        Largest = PN

    PN = int(input())
AVG = Total / Count
print(AVG)
print(Largest)