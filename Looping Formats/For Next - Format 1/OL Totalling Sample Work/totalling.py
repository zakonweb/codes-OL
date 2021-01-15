total = 0

Range = int(input("How many values?"))

for x in range(Range):
    val = int(input("Enter value" + str(x + 1)))

    total = total + val

print("Your total is =", total)