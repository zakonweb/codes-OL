Lar = -1000
Low = 1000
Total = 0

for count in range(5):
    DT = int(input())
    Fuel = int(input())

    FE = DT / Fuel
    print(FE)

    Total = Total + FE
    if FE > Lar: Lar = FE
    if FE < Low: Low = FE
Avg = Total / 5
print(Avg)
print(Lar)
print(Low)