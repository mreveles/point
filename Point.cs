using System;

namespace Point
{
    class Point{
        // public **public causes the variable to be acessed outside when its not meant to
        int x;
        int y;

        public Point(){
            x=0;
            y=0;
        }

        public Point(int x0 = 8, int y0 = 99){
            if(x0>=0){
                x=x0;
            }
            else{
                x=0;
            }
                 
            if(y0>=0){
                y = y0;
            }else{
                y=0;
            }
        }

        public void display(){
            Console.Write("({0},{1}) ",x,y);
        }
    }
}
