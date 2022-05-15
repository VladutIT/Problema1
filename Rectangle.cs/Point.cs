using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_2
{
    public enum Color
    {
        Negru,
        Rosu,
        Verde,
        Albastru,
        Galben
    }
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Color Culoare { get; set; }
        public Point(): this(0,0)//x=0 y=0
            {

            }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
            Culoare = Color.Negru;
            Console.WriteLine($"Am creat un obiect de tip Point ({X}, {Y})");
        }
        public Point(int x): this(x, 0)
        {
       
        }
        public override string ToString()
        {
            return $"[({X}, {Y}), {this.Culoare}]";
        }
        public double GetDistanceToOrigin()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public double GetDistanceTo(Point var)
        {
            return Math.Sqrt(Math.Pow(this.X - var.X, 2) +
                            Math.Pow(this.Y - var.Y, 2));
        }
        public void MoveBy(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }
        internal void WriteToConsole()
        {
            ConsoleColor color = Console.ForegroundColor;

            switch (Culoare)
            {
                case Color.Albastru:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Color.Galben:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Color.Rosu:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Color.Negru:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case Color.Verde:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
            Console.WriteLine(this);

            Console.ForegroundColor = color;
        }
    }
}
