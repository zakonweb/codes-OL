Total = 0
Highest = -1000
Lowest = 1000

for count in range(5):
    pop = int(input("Enter Population"))  # Input

    landArea = int(input("Enter Land Area"))  # Input

    popDen = pop / landArea
    print(popDen)

    Total = Total + pop

    if popDen > Highest:
        Highest = popDen

    if popDen < Lowest:
        Lowest = popDen

Avg = Total / 500
print(Highest)
print(Lowest)
print(Avg)