using System;
using Microsoft.Data.Sqlite;

namespace Calculator
{
    class Program
    {
        static string calculationsDB = @"CalculationHistory.db";
        static string useCountDB = @"CountUseCalc.db";
        static void Main(string[] args)
        {
            // Create Database SQLite for main data calculations
            using (var connection = new SqliteConnection(calculationsDB))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText =
                    @"CREATE TABLE IF NOT EXISTS calculations (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Solution TEXT,
                        Answer DOUBLE
                        )";
                command.ExecuteNonQuery();
                connection.Close();
            }
            // Create Database for storing how many times calculator is used
            using (var connection = new SqliteConnection(useCountDB))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText =
                    @"CREATE TABLE IF NOT EXISTS calculator_used (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        )";
                command.ExecuteNonQuery();
                connection.Close();
            }
            // Count how many times this calculator is used
            int useCount;

            // ======= UI ======= //
            Console.WriteLine($"This is the Calculator Console App. You used this Calculator {} times.");
            Console.WriteLine(""); // DateTime search it
            Console.WriteLine("What would you like to perform today? Please choose from the options below.\n");
            Console.WriteLine("Enter the letter of the operations you want to perform");
            Console.WriteLine("A - Addition");
            Console.WriteLine("S - Subtraction");
            Console.WriteLine("M - Multiplication");
            Console.WriteLine("D - Division");
            // ======= UI end ======= //

            ChooseSimpleOperations();

        }
        public static void ChooseSimpleOperations()
        {
            string input = Console.ReadLine(); // can be another method to validate right input

            // Conditional cases
            if (input.Trim() == "A")
            {
                Addition();
            }
            else if (input.Trim() == "S")
            {
                Subtraction();
            }
            else if (input.Trim() == "M")
            {
                Multiplication();
            }
            else if (input.Trim() == "D")
            {
                Division();
            }
            else
            {
                // method to go to choose options input again, loop again 
            }
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
        // ========================================================================== //
        // VALIDATION
        public static void ValidateInput()
        {

        }
        // DATABASE (storing and deleting list)
        
    }
}