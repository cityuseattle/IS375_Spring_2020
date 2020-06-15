using System;
using System.Security.Cryptography.X509Certificates;

namespace UserDefinedExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            //rasis an user-defined exception i.e. TempIsZeroException
            try
            {
                temp.showTemp();
            }
            //Catch block 1
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
        }
    }
}

public class TempIsZeroException : Exception
{
    //User-defined exception classes are derived from the Exception class
    public TempIsZeroException(string message) : base(message)
    {

    }
}

public class Temperature
{
    int temperature = 0; 

    public void showTemp()
    {
        if (temperature == 0)
        {
            throw (new TempIsZeroException("Zero Temperature found"));
        }
        else
        {
            Console.WriteLine("Temperature: {0}", temperature);
        }
    }
}