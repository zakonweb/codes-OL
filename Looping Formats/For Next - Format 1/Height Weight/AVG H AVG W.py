count = 0
h = 0.0
w = 0.0
th = 0.0
tw = 0.0
avg_h = 0.0
avg_w = 0.0

for count in range(1, 6):
    h = float(input("Enter height: "))
    w = float(input("Enter weight: "))

    th = th + h
    tw = tw + w

avg_h = th/5
avg_w = tw/5

print("avg height = ", avg_h)
print("avg weight = ", avg_w)

