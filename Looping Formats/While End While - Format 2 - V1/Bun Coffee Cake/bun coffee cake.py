b = 0
co = 0
ca = 0
s = 0
d = 0
total = 0

h = -1000

item = input("Enter item sold : ")  # INPUT

while item != "end":
    if item == "bun": b = b + 0.5
    elif item == "coffee": co = co + 1.2
    elif item == "cake": ca = ca + 1.5
    elif item == "sandwich": s = s + 2.1
    elif item == "dessert": d = d + 4

    item = input("Enter item sold: ")

total = b + co + ca + s + d

print("Total of all items sold :", total)

if b > h:
    h = b
    ty = "bun"

if co > h:
    h = co
    ty = "coffee"

if ca > h:
    h = ca
    ty = "cake"

if s > h:
    h = s
    ty = "sandwich"

if d > h:
    h = d
    ty = "dessert"

print("The item sold most is :", ty)