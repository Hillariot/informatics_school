from tkinter import *
root=Tk()
def fg1():
    if p1.get()==0:
        l8['text']='Kia'
    if p1.get()==1:
        l8['text']='Nissan'
    if p1.get()==2:
        l8['text']='Renault'

def fg2():
    er=lbox.curselection()
    er1=lbox.get(er)
    l9['text']=er1


def fg3():
    if p3.get()==0:
        l10['text']='1.4 л'
    if p3.get()==1:
        l10['text']='1.6 л'
    if p3.get()==2:
        l10['text']='2 л'

def fg4():
    if p4.get()==0:
        l11['text']='Стандарт'
    if p4.get()==1:
        l11['text']='Люкс'
    if p4.get()==2:
        l11['text']='Престиж'

def fg5():
    if cvar1.get()==1:
        l12['text']='Зимняя резина'
    if cvar2.get()==1:
        l13['text']='Панорамная крыша'


def fg6():
    l8['text']=''
    l9['text']=''
    l10['text']=''
    l11['text']=''
    l12['text']=''
    l13['text']=''




#фрэймы
i=LabelFrame(text='Марка')
i1=LabelFrame(text='Двигатель')
i2=LabelFrame(text='Комплектация')
i3=LabelFrame(text='Цвет')
i4=LabelFrame(text='Доп.опции')


#кнопки №1
p1=IntVar()
p1.set(0)
Kia=Radiobutton(i,text='Kia',variable=p1,value=0)
Nissan=Radiobutton(i,text='Nissan',variable=p1,value=1)
Renault=Radiobutton(i,text='Renault',variable=p1,value=2)
l=Button(i,width=13,height=1,bg='white',text="Выбрать марку",command=fg1)


#кнопки №2
lbox=Listbox(i3,width=13,height=6)
for op in('серебристый','чёрный','белый','синий','красный'):
    lbox.insert(END,op)
l3=Button(i3,width=16,height=1,bg='white',text="Выбрать цвет",command=fg2)


#кнопки №3
p3=IntVar()
p3.set(0)
y1=Radiobutton(i1,text='1.4 л',variable=p3,value=0)
y2=Radiobutton(i1,text='1.6 л',variable=p3,value=1)
y3=Radiobutton(i1,text='2 л',variable=p3,value=2)
l1=Button(i1,width=16,height=1,bg='white',text="Объём двигателя",command=fg3)



#кнопки №4
p4=IntVar()
p4.set(0)
y4=Radiobutton(i2,text='Стандарт',variable=p4,value=0)
y5=Radiobutton(i2,text='Люкс',variable=p4,value=1)
y6=Radiobutton(i2,text='Престиж',variable=p4,value=2)
l2=Button(i2,width=16,height=1,bg='white',text="Комплектация",command=fg4)


#Кнопки №5
cvar1=BooleanVar()
cvar1.set(0)
c1=Checkbutton(i4,text='Зимняя резина',variable=cvar1,onvalue=1,offvalue=0)
cvar2=BooleanVar()
cvar2.set(0)
c2=Checkbutton(i4,text='Панорамная крыша',variable=cvar2,onvalue=1,offvalue=0)
l7=Button(i4,width=13,height=1,bg='white',text="Выбрать",command=fg5)


#Изображение 1
l8=Label(root,width=13,height=1,bg='white')
l9=Label(root,width=13,height=1,bg='white')
l10=Label(root,width=13,height=1,bg='white')
l11=Label(root,width=13,height=1,bg='white')
l12=Label(root,width=13,height=1,bg='white')
l13=Label(root,width=13,height=1,bg='white')
l15=Button(root,width=13,height=1,bg='white',text="Очистить",command=fg6)


#расположение
i.pack(side=LEFT)
i3.pack(side=LEFT)
i1.pack(side=LEFT)
i2.pack(side=LEFT)
i4.pack(side=LEFT)
Kia.pack(side=TOP)
Nissan.pack(side=TOP)
Renault.pack(side=TOP)
l.pack(side=TOP)
lbox.pack(side=TOP)
l3.pack(side=TOP)
y1.pack(side=TOP)
y2.pack(side=TOP)
y3.pack(side=TOP)
l1.pack(side=TOP)
y4.pack(side=TOP)
y5.pack(side=TOP)
y6.pack(side=TOP)
l2.pack(side=TOP)
c1.pack(side=TOP)
c2.pack(side=TOP)
l7.pack(side=TOP)
l8.pack(side=TOP)
l9.pack(side=TOP)
l10.pack(side=TOP)
l11.pack(side=TOP)
l12.pack(side=TOP)
l13.pack(side=TOP)
l15.pack(side=TOP)
root.title('Автосалон')
root.mainloop()

