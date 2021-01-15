# Presence Check
name = input("Enter Name:")
while name == "":
    print("You can not leave this field blank. ReEnter Please.")
    name = input()

# Range Check
age = int(input("Enter Age:"))
while age < 15 or age > 20:
    print("Incorrect, ReEnter Please.")
    age = int(input())