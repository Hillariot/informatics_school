from random import *
k=[]
k1=[]
for i in range(5):
     k.append(randint(0,5))
     k1.append(randint(-5,0))

print(k)
print(k1)
print(k+k1)
print((k+k1).count(0))
