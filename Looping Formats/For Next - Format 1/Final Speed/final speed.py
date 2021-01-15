Count=0
Time=0
FS=0.0
total=0
Highest=-1000
Lowest=1000
Avg=0.0

for Count in range(1, 5):
  Time = int(input("Enter Time: "))

  FS = 200/Time
  print("Final speed:", FS)

  total = total + FS

  if FS > Highest: Highest = FS
  if FS < Lowest: Lowest = FS

Avg = total/5
print("Avg=", Avg, "Highest=", Highest, "Lowest=",Lowest)