using System;
using System.Reflection.Metadata.Ecma335;

namespace Abstraction
{
    abstract class Shape
    {
        //Abstract method
        public abstract int area();

    }
    //Square class inherting
    //The Shape class

    class Square : Shape
    {
        //Private data member
        private int side;

        public Square(int x = 0)
        {
            side = x;
        }

        //Overriding of the absract method of Shapre
        //Class using the override keyword

        public override int area()
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Creating reference of Shape class
            //Which refer to Square class instance
            Shape sh = new Square(4);

            //Calling the method
            double result = sh.area();

            Console.Write("{0}", result);
        }
    }
}