from random import *
a=100
b=100
while a>0 and b>0:
     h=int(randint(1,10))
     if h>5:
          a=a-20
          print('Первый юнит атаковал второго.')
          print(a)
     if h<5:
          b=b-20
          print('Второй юнит атаковал первого.')
          print(b)
if a>0:
     print('Первый игрок победил.')
if b>0:
     print('Второй игрок победил.')

     
