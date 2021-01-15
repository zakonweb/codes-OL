A = 0
B = 0
Lowest = 1000

for count in range(5):
    Temp = int(input())

    if Temp > 20: A = A + 1
    if Temp < 10: B = B + 1
    if Temp < Lowest: Lowest = Temp
print(A)
print(B)
print(Lowest)