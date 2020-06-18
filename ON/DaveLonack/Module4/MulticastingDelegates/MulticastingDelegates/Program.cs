using System;

namespace MulticastingDelegate
{
    class Rectangle
    {
        //Declaring delegate
        public delegate void rectDelegate(double height, double width);
        //"Area" method
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));

        }
        //"Perimiter" method
        public void permiter(double height, double width)
        {
            Console.WriteLine("Perimiter is: {0}", 2 * (width + height));
        }

        //Main Method

        public static void Main(String[] args)
        {
            //Creating object of class
            //"Rectangle", named as "rect"
            Rectangle rect = new Rectangle();

            //Creating delegate object, name as "rectdele" and pass the method as a parameter by
            //class object "rect"
            rectDelegate rectdele = new rectDelegate(rect.area);
            //Also can be written as rectDelegate rectdele = rect.area;

            //Call 2nd method "perimeter"
            //Multicasting
            rectdele += rect.permiter;

            //Pass the values in two method
            //By using "Invoke" method
            rectdele.Invoke(6.3, 4.2);
            Console.WriteLine();

            //Call the methods with different values
            rectdele.Invoke(16.3, 10.3);
        }
    }
}