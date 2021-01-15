names = ["" for i in range(5)]
gde = ["" for i in range(5)]

for i in range(5):
    names[i] = input()
    gde[i] = input()

searchGDE = input("Enter Grade to search for: ")
for i in range(5):
    if searchGDE == gde[i]: print(names[i])