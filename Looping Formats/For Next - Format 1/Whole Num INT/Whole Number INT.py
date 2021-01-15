Count=0
Num=0.0
X=0
A=0
for Count in range(10):
   Num = float(input("Input number: "))
   X = int(Num)
   if X==Num: A = A + 1

print("Entry was correct ", A, " times.")