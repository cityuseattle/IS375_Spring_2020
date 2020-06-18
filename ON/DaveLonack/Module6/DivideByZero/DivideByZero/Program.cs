using System;

namespace DivideByZero
{
    class program
    {
        static void Main(string[] args)
        {
            //Here, number is greater than divisor
            int[] number = { 8, 17, 24, 5, 25 };
            int[] divisor = { 2, 0, 0, 5 };

            for (int j = 0; j< number.Length; j++)
                //Two different types of exception, i.e., DividebyZeroException
                //and IndexOutOfRangeException raise here
                try
                {
                    Console.WriteLine("Number : " + number[j]);
                    Console.WriteLine("Divisor: " + divisor[j]);
                    Console.WriteLine("Quotient: " + number[j] / divisor[j]);
                }
                //Catch block 1
                //This catch block is for handling Divideby ZeroException
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Not possible to Divide by zero");
                }
            //Catch block 2
            //This Catch block is for handling IndexOutOfRangeException
            catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index is out of range");
                }
        }
    }
}