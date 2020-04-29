Count=0
X=0
Code=0
CD=0
DVD=0
Vid=0
Book=0

for Count in range(1,5):
    Code = int(input("Enter item code: "))
    X = int(Code/10000)
    if X == 1: CD=CD+1
    if X == 2: DVD=DVD+1
    if X == 3: Vid=Vid+1
    if X == 4: Book=Book+1
    if X > 4: print("Invalid code.")

print("CD=", CD, "DVD=", DVD, "Video=", Vid, "Book=", Book)