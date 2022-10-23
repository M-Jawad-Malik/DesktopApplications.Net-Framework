#int32/int64-integer
#bool-boolean
#u-unicode string
#o-object
#c-complex
import numpy as np
arr=np.array(['Faizan','Hassan','Azfar','Mahnoor','Zaman'])
arr1=np.array([1,2,3,4,5,6,7])
arr2=np.array([True,False,True,False])
print(arr.dtype)
print(arr1.dtype)
print(arr2.dtype)
arr3=np.array([1.2,2.4,5.6])
print(arr3.dtype)
arr_new=arr1.astype('S')
print(arr_new.dtype)