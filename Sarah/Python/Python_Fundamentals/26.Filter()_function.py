def filtervowel(a):
    v=['a','e','i','o','u']
    if a in v:
        return True
    else:
        return False

alpha=['a','b','c','d','e','f','g','h','i']
r=filter(filtervowel,alpha)
print('Vowels after filteration are: ')
for i in r:
    print(i)
# To see more consult EX3.Filter_function.py#