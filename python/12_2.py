from tkinter import *
from random import *
tk=Tk()
h=400
w=400
canvas=Canvas(tk,width=h,height=w)
canvas.pack()
color=['red','green','blue','orange','grey','purple']
def random_triangle():
     p1=randrange(w)
     p2=randrange(h)
     p3=randrange(w)
     p4=randrange(h)
     p5=randrange(w)
     p6=randrange(h)
     colors=choice(color)
     canvas.create_polygon(p1,p2,p3,p4,p5,p6,fill=colors,outline='')
for i in range(1,20):
     random_triangle()
tk.mainloop
