import numpy as np
arr=np.array([41,42,52,67,78,90])
l=[]
for i in arr:
    if i >52:
        l.append(True)
    else:
        l.append(False)
new=arr[l]
print(new)

