Total = 0
H = -1000
L = 1000

for count in range(5):
    POP = int(input("Enter population of country #" + str(count+1) + "  :"))

    LA = int(input("Enter land area of country "))

    PD = POP / LA
    print("Population density of Country #" + str(count+1), "is =", PD)

    Total = Total + POP

    if PD > H:
        H = PD

    if PD < L:
        L = PD

Avg = Total / 5

print("Average PD is =", Avg, "and highest PD is =", H, "and lowest PD is =", L)