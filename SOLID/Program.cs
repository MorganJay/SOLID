using System;

namespace SOLID
{
    internal class Program
    {
        private static void Main()
        {
            var wall = new Wall { Breadth = 5, Length = 67 };
            Console.WriteLine(wall.Area());
            Console.ReadLine();
        }
    }
}