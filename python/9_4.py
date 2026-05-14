y1=[]
y5=[]
for i in range(1,11):
     y=[]
     for i1 in range(1,11):
          y.append(i*i1)
          if len(y)==10:
               print(y)
          y4=y
          if (i*i1)%2==0:
               y4.insert(y4.index(i*i1),0)
     y1.append(y)
     y5.append(y4)
y2=[]
for i in range(1,11):
     y2.append(i**2)
print(y2)
for u in y5:
     print(u)

