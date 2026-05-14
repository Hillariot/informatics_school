from tkinter import *
from time import *
tk=Tk()
canvas=Canvas(tk,width=1000,height=800)
canvas.pack()
s=PhotoImage(file='1.png')
canvas.create_image(0,0,anchor=NW,image=s)
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
for x in range(0,35):
     canvas.move(1,10,10)
     tk.update()
     sleep(0.1)
for x in range(0,35):
     canvas.move(1,-10,-10)
     tk.update()
     sleep(0.1)
tk.mainloop()
