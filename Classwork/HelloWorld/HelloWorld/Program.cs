/*
 * Lab 1
 * Your Name
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    // Single line comment
    class Program
    {
        static void Main( string[] args )
        {
            NewGame();
            DisplayGame();
        }
  

        private static void NewGame()
        {
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();

            /*Console.WriteLine("Do you own this? ");
            string owned = Console.ReadLine();*/
            owned = ReadBool("Owned (Y/N)?");

            /*Console.WriteLine("Price? ");
            string price = Console.ReadLine();*/
            price = ReadDecimal("Price? ");

            Console.WriteLine("Publisher? ");
            publisher = Console.ReadLine();

            /*Console.WriteLine("Completed? ");
            string completed = Console.ReadLine();*/
            
            completed = ReadBool("Completed (Y/N)?");
        }

        private static void DisplayGame()
        {
            string literalOne = "wutup bob";
            Console.WriteLine("Name:\t" + name);
            Console.WriteLine("Price:\t" + price);
            Console.WriteLine("Publisher:\t" + publisher);
            Console.WriteLine("Owned?:\t" + owned);
            Console.WriteLine("Completed:\t" + completed);
        }

        private static bool ReadBool( string message)
        {
            Console.WriteLine(message);
            string result = Console.ReadLine();

            //Validate it's a bool
            //TODO: Fix this expression
            if (result == "Y" || result == "y")
                return true;
            if (result == "N" || result == "n")
                return false;
            //TODO: Add validation
            return false;
        }


        private static decimal ReadDecimal (string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine();

            decimal result;
            //parse accepts a string and returns corresponding data type. Decimal is capital D, decimal lowercase d...
            /* bool TryParse( string input, out decimal result );
            /* the "out" tells you it's an out parameter ("passing in reference variable) */
            if (Decimal.TryParse(value, out result))
                return result;

            return 0;
        }

        private static void CSharpBasics()
        {
            string name;
            int hours = 8; //8L
            double payRate = 8.25; //8.25F
            int length = 10, width = 12;
            int aReallyLongIdentifierJustToSeeHowLongICanGo;
            char ch = 'X';
            bool result = true; //false
            //int counter;

            //Never!!!!

            //int a, b;            
            Console.WriteLine(hours);
            //name = "Sue";
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            //string message = "Hello " + name;
            string message = "Hello ";
            message += name;

            Console.WriteLine(message);
            //Console.Write("Hello ");
            //Console.WriteLine(name);
        }
        private static string name;
        private static string publisher;
        private static decimal price;
        private static bool owned;
        private static bool completed;
    }
}
