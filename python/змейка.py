from tkinter import *
import random
wid=800
heig=600
seg_size=20
in_game=True
class Segment(object):
     def __init__(self,x,y):
          self.instance=c.create_rectangle(x,y,x+seg_size,y+seg_size,fill='blue')
class Snake(object):
     def __init__(self,segments):
          self.segments=segments
          self.mapping={'Down':(0,1),'Up':(0,-1),'Left':(-1,0),'Right':(1,0)}
          self.vector=self.mapping['Right']
     def move(self):
          for index in range(len(self.segments)-1):
               segment=self.segments[index].instance
               x1,y1,x2,y2=c.coords(self.segments[index+1].instance)
               c.coords(segment,x1,y1,x2,y2)
          x1,y1,x2,y2=c.coords(self.segments[-2].instance)
          c.coords(self.segments[-1].instance,x1+self.vector[0]*seg_size,y1+self.vector[1]*seg_size,x2+self.vector[0]*seg_size,y2+self.vector[1]*seg_size)
     def change_direction(self,event):
          if event.keysym in self.mapping:
               self.vector=self.mapping[event.keysym]
     def add_segment(self):
          last_seg=c.coords(self.segments[0].instance)
          x=last_seg[2]-seg_size
          y=last_seg[3]-seg_size
          self.segments.insert(0,Segment(x,y))
     def reset_snake(self):
          for segment in self.segments:
               c.delete(segment.instance)
def create_block():
     global block
     posx=seg_size*(random.randint(1,(wid-seg_size)/seg_size))
     posy=seg_size*(random.randint(1,(heig-seg_size)/seg_size))
     block=c.create_oval(posx,posy,posx+seg_size,posy+seg_size,fill='red')
def main():
     global in_game
     if in_game:
          s.move()
          head_coords=c.coords(s.segments[-1].instance)
          x1,y1,x2,y2=head_coords
          if x2>wid or x1<0 or y1<0 or y2>heig:
               in_game=False
          elif head_coords==c.coords(block):
               s.add_segment()
               c.delete(block)
               create_block()
          else:
               for index in range(len(s.segments)-1):
                    if head_coords==c.coords(s.segments[index].instance):
                         in_game=False
          root.after(100,main)
     else:
          set_state(restart_text,'normal')
          set_state(game_over_text,'normal')
def clicked(event):
     global in_game
     s.reset_snake()
     in_game=True
     c.delete(block)
     c.itemconfigure(restart_text,state='hidden')
     c.itemconfigure(game_over_text,state='hidden')
     start_game()
def set_state(item,state):
     c.itemconfigure(item,state=state)
def start_game():
     global s
     create_block()
     s=create_snake()
     c.bind('<KeyPress>',s.change_direction)
     main()
def create_snake():
     segments=[Segment(seg_size,seg_size),Segment(seg_size*2,seg_size),Segment(seg_size*3,seg_size)]
     return Snake(segments)
root=Tk()
root.title('Змейка')
c=Canvas(root,width=wid,height=heig,bg='green')
c.pack()
c.focus_set()
game_over_text=c.create_text(wid/2,heig/2,text='Игра окончена.',font='Arial 20',fill='red',state='hidden')
restart_text=c.create_text(wid/2,heig-heig/3,font='Arial 30',fill='white',text='Нажмите, чтобы начать заново!',state='hidden')
c.tag_bind(restart_text,'<Button-1>',clicked)
start_game()
root.mainloop
