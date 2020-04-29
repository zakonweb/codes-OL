count = 0
name = ""
choice = 0
r=s=p=j=c=0
pr=ps=pp=pj=pc=0.0

for count in range(1500):
   name = input("Enter Name: ")
   choice = int(input("Enter Choice 1...5: "))

   if choice == 1: r=r+1
   if choice == 2: s=s+1
   if choice == 3: p=p+1
   if choice == 4: j=j+1
   if choice == 5:
      c = c + 1
      print(name)

pr = r/15
ps = s/15
pp = p/15
pj = j/15
pc = c/15

print(pr, ps, pp, pj, pc)