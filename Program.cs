using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // ======= UI ======= //
            Console.WriteLine("This is the Calculator Console App\n");
            Console.WriteLine(""); // DateTime search it
            Console.WriteLine("What would you like to perform today? Please choose from the options below.\n");
            Console.WriteLine("Enter the letter of the operations you want to perform");
            Console.WriteLine("A - Addition");
            Console.WriteLine("S - Subtraction");
            Console.WriteLine("M - Multiplication");
            Console.WriteLine("D - Division");
            // ======= UI end ======= //
            Addition();
        }

        // Simple Operations
        public static void Addition()
        {
            Console.WriteLine("You chose Addition! Please the numbers:");
            // Get input orrrrrrr can have validation method to get input,
            // which validates that input is a number [refactor later]
            Console.WriteLine("Enter first value:");
            string value1 = Console.ReadLine(); // need validation here
            Console.WriteLine("Enter second value:");
            string value2 = Console.ReadLine(); // need validation here

            // Convert to int
            int finalValue1 = Convert.ToInt32(value1);
            int finalValue2 = Convert.ToInt32(value2);
            // Perform operation
            int finalResult = finalValue1 + finalValue2;

            // Display result
            Console.WriteLine(finalResult);
            // Display solution of result
            Console.WriteLine($"{finalValue1} + {finalValue2} = {finalResult}");
        }

        public static void Subtraction()
        {
            Console.WriteLine("You chose Subtraction! Please the numbers:");
            // Get input orrrrrrr can have validation method to get input,
            // which validates that input is a number [refactor later]
            Console.WriteLine("Enter first value:");
            string value1 = Console.ReadLine(); // need validation here
            Console.WriteLine("Enter second value:");
            string value2 = Console.ReadLine(); // need validation here

            // Convert to int
            int finalValue1 = Convert.ToInt32(value1);
            int finalValue2 = Convert.ToInt32(value2);
            // Perform operation
            int finalResult = finalValue1 - finalValue2;

            // Display result
            Console.WriteLine(finalResult);
            // Display solution of result
            Console.WriteLine($"{finalValue1} - {finalValue2} = {finalResult}");
        }
        
        public static void Multiplication()
        {
            Console.WriteLine("You chose Multiplication! Please the numbers:");
            // Get input orrrrrrr can have validation method to get input,
            // which validates that input is a number [refactor later]
            Console.WriteLine("Enter first value:");
            string value1 = Console.ReadLine(); // need validation here
            Console.WriteLine("Enter second value:");
            string value2 = Console.ReadLine(); // need validation here

            // Convert to int
            int finalValue1 = Convert.ToInt32(value1);
            int finalValue2 = Convert.ToInt32(value2);
            // Perform operation
            int finalResult = finalValue1 * finalValue2;

            // Display result
            Console.WriteLine(finalResult);
            // Display solution of result
            Console.WriteLine($"{finalValue1} * {finalValue2} = {finalResult}");
        }
        
        public static void Division()
        {
            Console.WriteLine("You chose Division! Please the numbers:");
            // Get input orrrrrrr can have validation method to get input,
            // which validates that input is a number [refactor later]
            Console.WriteLine("Enter first value:");
            string value1 = Console.ReadLine(); // need validation here
            Console.WriteLine("Enter second value:");
            string value2 = Console.ReadLine(); // need validation here

            // Convert to int
            int finalValue1 = Convert.ToInt32(value1);
            int finalValue2 = Convert.ToInt32(value2);
            // Perform operation
            int finalResult = finalValue1 / finalValue2;

            // Display result
            Console.WriteLine(finalResult);
            // Display solution of result
            Console.WriteLine($"{finalValue1} / {finalValue2} = {finalResult}");
        }
    }
}