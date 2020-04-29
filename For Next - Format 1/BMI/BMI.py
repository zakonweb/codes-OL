count = 0
ID = 0
w = 0
h = 0
bmi = 0.0

for count in range(1,30):
    ID = int(input("Enter ID: "))
    w = int(input("Enter weight: "))
    h = int(input("Enter Height: "))

    bmi = w/h**2
    print("ID:", ID, "BMI:", round(bmi))

    if bmi > 25: print("OVER WEIGHT")
    if bmi < 19: print("UNDER WEIGHT")
    if bmi >= 19 and bmi <= 25: print("NORMAL")
