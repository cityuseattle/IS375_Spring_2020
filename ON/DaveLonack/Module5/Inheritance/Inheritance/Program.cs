﻿using System;

namespace Inheritance
{
    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }
    //Derived class

    class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            Rect.setWidth(5);
            Rect.setHeight(7);

            //Print the area of an object
            Console.WriteLine("Total area: {0}", Rect.getArea());
        }
    }
}