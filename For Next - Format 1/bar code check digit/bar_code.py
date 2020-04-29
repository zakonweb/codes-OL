count = 0
a = b = c = d = e = x = n = 0
for count in range(1,3):
    a = int(input("Enter a: "))
    b = int(input("Enter b: "))
    c = int(input("Enter c: "))
    d = int(input("Enter d: "))
    e = int(input("Enter e: "))

    x = (a*3 + b*2 + c*3 + d*2) % 10
    if x == e: n = n + 1

print("Correct barcodes were:", n)
