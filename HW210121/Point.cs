using System;

namespace HW210121
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }


        public Point()
        {
        }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void ShowData()
        {
            Console.WriteLine("Point({0},{1})", X, Y);
        }
    }
}