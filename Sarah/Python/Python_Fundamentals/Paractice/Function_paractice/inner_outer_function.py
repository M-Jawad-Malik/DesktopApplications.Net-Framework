inner=lambda x,y:x+y
def outer(x,y):
    out=inner(x,y)+5
    return  out
res=outer(4,5)
print(res)