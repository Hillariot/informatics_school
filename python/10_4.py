class Person:
     def __init__(self,n,s,qual=1):
          self.name=n
          self.surname=s
          self.qual=qual
          return n,s,qual
     def __del__(self):
          print(f"До свидания,{self.name},{self surname}")
person1=Person('Артём','Кузнецов','4')
person2=Person('Никита','Кузнецов','5')
person3=Person('Сергей','Кузнецов','6')




