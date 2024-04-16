using System;

namespace W4Demo
{
    class Program
    {   
        struct Point
        {
            public int X;
            public int Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
        static Point GetRandomPoint()
        {
    
            Random r = new Random();
            Point p = new Point(r.Next(-100,100), r.Next(-100, 100));
            return p;
        }
        static void Main(string[] args)
        {
            Point p = GetRandomPoint();
            Console.WriteLine($"X: {p.X}, Y: {p.Y}");
        }
    }
}