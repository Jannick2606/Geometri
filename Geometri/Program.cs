using System;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(5);
            Console.WriteLine(s.Perimeter());
            Console.WriteLine(s.Area());
            s.Side = 1;
            Console.WriteLine(s.Perimeter());
            Console.WriteLine(s.Area()); 
        }
    }
}
