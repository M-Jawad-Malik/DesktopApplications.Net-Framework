import numpy as np
a=np.array([1,2,3,4,5,6,7,8])
copy_arr=a.copy()
view_arr=a.view()
#print(copy_arr,view_arr,sep='\n')
a[4]=89
#print(copy_arr,view_arr,sep='\n')

print(copy_arr.base)
print(view_arr.base)