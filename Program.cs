using System;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point(3,6);

            p1.display();
            p2.display();
            p1.x=10;
            p1.display();
        }

    }
}
