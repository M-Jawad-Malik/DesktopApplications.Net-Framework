import numpy as np
arr1=np.array([1,2,3,4,5,45,56,5,85,9])
arr2=np.array([  [1,2],[4,5],[11,12],[14,15] ])
arr3=np.array([   [ [11,12] ], [  [13,12] ] ,[ [21,22] ], [  [23,32] ]  ])

for x in arr1:
    print('I am element of 1-d array: ',x)
for x in arr2:
    for y in x:
        print('I am element of 2-d array: ', y)
for x in arr3:
    for y in x:
        for z in y:
            print('I am Element of 3-D array:', z)
