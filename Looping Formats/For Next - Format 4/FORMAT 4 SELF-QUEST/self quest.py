old = -1000
young = 1000
X = 0

for Cl in range(1,3):
    tot1 = 0
    Avg1 = 0
    for Stu in range(1,4):
        age = int(input())
        Gde = input()

        tot1 = tot1 + age
        if Gde == "A": X = X + 1

        if age > old: old = age
        if age < young: young = age
    Avg1 = tot1/3
    print(Avg1)
per = (X / 6) * 100
print(X)
print(per)
print(old)
print(young)