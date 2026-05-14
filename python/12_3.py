from tkinter import *
from time import *
tk=Tk()
canvas=Canvas(tk,width=1000,height=800)
canvas.pack()
canvas.create_polygon(100,100,200,200,100,200,fill='red',outline='black')
for x in range(0,35):
     canvas.move(1,10,0)
     tk.update()
     sleep(0.1)
for x in range(0,35):
     canvas.move(1,0,10)
     tk.update()
     sleep(0.1)
for x in range(0,35):
     canvas.move(1,-10,0)
     tk.update()
     sleep(0.1)
for x in range(0,35):
     canvas.move(1,0,-10)
     tk.update()
     sleep(0.1)
tk.mainloop()
