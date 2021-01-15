names = ["" for i in range(5)]
isFound = False

for i in range(5):
    names[i] = input()

searchName = input()
for i in range(5):
    if searchName == names[i]:
        isFound = True
        print("Found @", i+1)
if not isFound: print("Not Found.")