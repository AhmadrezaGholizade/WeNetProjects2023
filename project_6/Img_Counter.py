with open("Pinterest.xml", "r", encoding='utf-8') as file:
    lines = file.readlines()
    sum = 0
    for line in lines:
        sum += line.count("<img")

print("Number of img tags:", sum)

