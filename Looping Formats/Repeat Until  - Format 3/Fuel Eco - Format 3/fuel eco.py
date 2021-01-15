FE = 0
Total = 0
Highest = -1000
Lowest = 1000
AVG = 0

for Count in range(5):
    DT = int(input())
    Fuel = int(input())

    FE = DT / Fuel
    print(FE)

    Total = Total + FE

    if FE > Highest: Highest = FE
    if FE < Lowest: Lowest = FE

AVG = Total / 5

print(AVG)
print(Highest)
print(Lowest)