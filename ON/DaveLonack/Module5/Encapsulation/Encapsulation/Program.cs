using System;

namespace Encapsulation
{
    public class DemoEncap
    {
        //Private variables declared
        //these can only be access by
        //public methods of class
        private String studentName;
        private int studentAge;

        //Using accessors to get and
        //set the value of studentName

        public String Name
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }
        public int Age
        {
            get
            {
                return studentAge;

            }
            set
            {
                studentAge = value;
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                //creating object
                DemoEncap obj = new DemoEncap();

                //calls set accessor of the property name,
                //and passes "Ankita" as value of the 
                //standard field 'value'
                obj.Name = "Ankita";

                //calls set accessor of the property Age,
                //and pass "21" as value of the
                //standard field 'value'
                obj.Age = 21;

                //Displaying values of the variables
                Console.WriteLine("Name: " + obj.Name);
                Console.WriteLine("Age: " + obj.Age);
            }
        }
    }
}