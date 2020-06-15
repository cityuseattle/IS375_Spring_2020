using System;
using System.IO;

namespace ReadingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Create an instance of StreamReader to read from a file.
                //The using statement also closes the StreamReader.
                using(StreamReader sr = new StreamReader("C:/Users/Lonac/source/repos/IS375_Spring_2020/ON/DaveLonack/Module6/jamaica.txt"))
                {
                    string line;

                    //Read and display lines from the file until
                    //the end of the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                //let the user know what went wrong.

                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}