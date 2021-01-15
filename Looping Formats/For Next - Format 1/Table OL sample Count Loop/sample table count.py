Table = int(input("Table? "))

Range = int(input("Upto ?"))

for Count in range(Range):
    Product = Table * (Count+1)
    print(Table, "x", Count+1, "=", Product)