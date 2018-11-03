using System;

namespace FirstAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Juree";
            string middleInitial = "J";
            string lastName = "Fitzgerald";
            string fullName = "Juree J Fitzgerald";

            int age = 22;
            int heightFeet = 5;

            bool isCitizen = true;
            bool canVote = true;

            double heightInches = 4;
            double totalHeightCM = 162.54;

            Console.WriteLine("What is your first name?");
            firstName = System.Console.ReadLine();

            Console.WriteLine("What is your middle inital?");
            middleInitial = System.Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastName = System.Console.ReadLine();

            Console.WriteLine("What is your full name?");
            fullName = System.Console.ReadLine();

            Console.WriteLine("What is your height in feet?");
            heightFeet = int.Parse(System.Console.ReadLine());

            Console.WriteLine("What is your height in inches?");
            heightInches = double.Parse(System.Console.ReadLine());

            double inchHeight = 4;
            double feetHeight = 5;
            double inchConversion = 4*2.54;
            double feetConversion = 5 * 2.54;

            double centiToFoot = 2.54;
            double centiToInch = 2.54;

            centiToFoot = 12.7;
            centiToInch = 10.16;
           
            Console.WriteLine("Total height in centimeters?");
            totalHeightCM = double.Parse(System.Console.ReadLine());

            Console.WriteLine("What is your age?");
            age = int.Parse(System.Console.ReadLine());

            Console.WriteLine("Are you a citizen?");
            isCitizen = bool.Parse(System.Console.ReadLine());

            Console.WriteLine("Can you vote?");
            canVote = bool.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();




        }
    }
}
