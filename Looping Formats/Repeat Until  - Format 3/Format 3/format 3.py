Num = 0
Total = 0
Lar = -1000
Avg = 0
Count = 0

while Num != -1:
    Num = int(input())
    Total = Total + Num
    if Num > Lar: Lar = Num

    Count = Count + 1
Avg = Total / Count
print("Largest =", Lar)
print("Average =", Avg)