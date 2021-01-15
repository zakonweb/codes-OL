Count=0
FC=""
F=S=K=0
PF=PS=PK=0.0

for Count in range(1,6):
  FC = input("Enter flight code: ")

  if FC == "FA":
     F=F+1
  if FC == "SJ":
     S=S+1
  if FC == "KA":
     K=K+1

PF=F/400*100
PS=S/400*100
PK=K/400*100

print(PF, PS, PK)