import sys

NIC = input("Enter String in Format 99999-AAAAAAA-9 : ")

# 1. Length Check
if len(NIC) != 15:
    print("Not Valid")
    sys.exit()

# 2. Identify fixed positions and check for them
if NIC[5:6] != "-" or NIC[13:14] != "-":
    print("Not Valid")
    sys.exit()

# 3. Identify Groups and check for them.
for count in range(5):
    CH = NIC[count:count+1]
    if "0" > CH > "9":
        print("Not Valid")
        sys.exit()

for count in range(6,13):
    CH = NIC[count:count+1]
    if "A" > CH > "Z":
        print("Not Valid")
        sys.exit()

CH = NIC[14]
if "0" > CH > "9":
    print("Not Valid")
    sys.exit()

print("Valid String")