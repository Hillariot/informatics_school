class Data:
     def __init__(self,*info):
          self.info=list(info)
     def __getitem__(self,i):
          return self.info[i]
class Teacher:
     def teach(self,info,*pupil):
          for i in pupil:
               i.take(info)
class Pupil:
     def __init__(self):
          self.knowledge=[]
     def take(self, info):
          self.knowledge.append(info)
lesson=Data('список','кортэж','словарь')
Uchit=Teacher()
Uchen1=Pupil()
Uchen2=Pupil()
Uchen3=Pupil()
Uchit.teach(lesson[1],Uchen1)
Uchit.teach(lesson[0],Uchen1,Uchen2,Uchen3)
print(Uchen1.knowledge)
print(Uchen2.knowledge)
print(Uchen3.knowledge)

