p=input('Введите строку:')
p1=p
o=len(p)
if o>8:
     print('Слишком большая строка.')
if o<8:
     while o!=8:
          p1=p1+'*'
          o=len(p1)
     print(p1)
