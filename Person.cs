using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static double SumOfAllAges;

        public string GetFullName()
        {
            return this.LastName + " " + this.FirstName;
        }

        public void PrintNameAndAge()
        {
            Console.WriteLine("My name is " + this.GetFullName() + ".");
            Console.WriteLine("My age is " + this.Age + ".");
        }
    }
}
