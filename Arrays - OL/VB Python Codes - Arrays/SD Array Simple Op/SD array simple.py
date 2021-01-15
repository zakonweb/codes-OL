stuNames = []

# Initialisation
for i in range(5):
    stuNames.append("")

# Population
for i in range(5):
    sN = input("Enter name " + str(i+1) + ": ")
    stuNames[i] = sN

# Reading an Array
for i in range(5):
    sN = stuNames[i]
    print(sN)

# Searching
n2s = input("Enter name to search: ")
for i in range(5):
    sN = stuNames[i]
    if sN == n2s: print(sN, "is found @", i+1)