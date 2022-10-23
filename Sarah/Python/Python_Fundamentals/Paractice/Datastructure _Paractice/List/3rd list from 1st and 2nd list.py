listOne = [3, 6, 9, 12, 15, 18, 21]
listTwo = [4, 8, 12, 16, 20, 24, 28]
listthree=list()
listthree.extend(listOne[1::2])
listthree.extend(listTwo[0::2])
print(listthree)