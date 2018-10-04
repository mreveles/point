using System;

namespace Point
{
    class Point{
        public 
        int x;
        int y;

        public Point(){
            x=0;
            y=0;
        }

        public Point(int x0=8, int y0=99){
            x=x0;
            x=y0;
        }

        public void display(){
            Console.Write("({0},{1}) ",x,y);
        }
    }
}
