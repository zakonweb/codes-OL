Names = ["" for i in range(5)]
Test1 = [0 for i in range(5)]
Test2 = [0 for i in range(5)]
Test3 = [0 for i in range(5)]
Total = [0 for i in range(5)]

GT = 0

for i in range(5):
    Names[i] = input()
    Test1[i] = int(input())
    Test2[i] = int(input())
    Test3[i] = int(input())
    Total[i] = Test1[i] + Test2[i] + Test3[i]

    GT = GT + Total[i]

for i in range(5):
    print(Names[i], "\b,", Total[i])

Avg = GT / 5
print("Average :", Avg)

Highest = -1000
for i in range(5):
    if Total[i] > Highest: Highest = Total[i]

print("Highest =", Highest)