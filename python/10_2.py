class Dog:
     def __init__(self):
          name=""
class Human:
     def __init__(self,dog):
          self.dog=dog
     def dog_name(self):
          self.dog_name=input()
          return self.dog_name
d=Dog()
m=Human(d)
dog_name=m.dog_name()
print(dog_name)


