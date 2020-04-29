TN=0
B=0
for day in range(1,8):
  A=0
  N = int(input("Enter enquiries for the day: "))
  TN = TN + N
  for enq in range(N):
      HouseCost = int(input("Enter house cost: "))

      if HouseCost < 100000: A = A + 1
      if HouseCost > 500000: B = B + 1

  print("Houses enquiries for cost less than 100000 were ", A)

Per = (B/TN)*100
print("Percentage of enquiries for cost above 500000 were ", Per)