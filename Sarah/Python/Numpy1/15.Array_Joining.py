import numpy as np
arr1=np.array([1,2,3,4,5,6,7,8,9])
arr2=np.array([12,1,3,14,15,15,16])
arr=np.concatenate((arr1,arr2))
print(arr)
arr3=np.array([  [1,2],[4,5],[11,12],[14,15] ])
arr4=np.array([ [1,2] ,[3,4],[12,14],[13,15]  ])
arr_new=np.concatenate((arr3,arr4))
print(arr_new)