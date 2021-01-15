namesArr = []
isFound = False

# Initialisation
for a in range(5):
    namesArr.append("")

# Populate
for a in range(5):
    sName = input("Enter name:" + str(a+1) + " ")
    namesArr[a] = sName

# Output all
for a in range(5):
    print(namesArr[a])

# Linear or simple searching()
sName = input("Enter Name to search for: ")
for a in range(5):
    if namesArr[a] == sName:
        print(a+1)
        isFound = True
if not isFound:
    print("Name was not found.")