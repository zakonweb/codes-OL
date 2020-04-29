day=0
Total=0
AvgD=0.0
reading=0
Temp=0
Highest=-1000
Lowest=1000
GTotal=0
AvgY=0.0

for day in range(365):
  Total=0
  AvgD=0.0

  for reading in range(10):
    Temp = int(input("Enter temperature: "))
    Total = Total + Temp

    if Temp > Highest: Highest = Temp
    if Temp < Lowest: Lowest = Temp

  GTotal = GTotal + Total
  AvgD = Total/10
  print("Average of the day= ", AvgD)

AvgY = GTotal/3650
print(Highest, Lowest, AvgY)