def calculateSum(num,num2):
    if num<=num2:
        return num + calculateSum(num+1,num2)
    else:
        return 0

res = calculateSum(0,20)
print(res)