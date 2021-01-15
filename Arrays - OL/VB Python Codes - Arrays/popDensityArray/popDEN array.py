pop = []
la = []
pd = []
tot = 0

for count in range(5):
    pop.append(0)
    la.append(0)
    pd.append(0)

H = -1000
L = 1000

# TASK1
for count in range(5):
    pop[count] = int(input())
    la[count] = int(input())

# TASK2
for count in range(5):
    pd[count] = pop[count] / la[count]

    tot = tot + pd[count]

for count in range(5):
    if pd[count] > H:
        H = pd[count]

    if pd[count] < L:
        L = pd[count]
avg = tot / 5
print(avg, " \b", H, " \b", L)