c = 0
r = 0
s = 0
f = 0
Highest = -1000
lowest = 1000

for count in range(5):
    WT = input()
    Temp = int(input())

    if WT == "CLOUDY": c = c + 1
    if WT == "RAINING": r = r + 1
    if WT == "SUNNY": s = s + 1
    if WT == "FOGGY": f = f + 1

    if Temp > Highest: Highest = Temp
    if Temp < lowest: lowest = Temp

print(c)
print(r)
print(s)
print(f)
print(Highest)
print(lowest)