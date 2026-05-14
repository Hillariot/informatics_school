print('Введите 5 слов.')
list1=[]
list2=[]
for i in range(5):
     a=input()
     list1.append(a)
     b=len(a)
     list2.append(b)
print(list1)
print(list2)
p=max(list2)
list3=[]
for i1 in list1:
     if len(i1)<p:
          j=p-len(i1)
          i1=i1+'-'*j
          list3.append(i1)
print(list3)
