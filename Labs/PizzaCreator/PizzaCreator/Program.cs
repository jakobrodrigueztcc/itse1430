/*
 * Pizza Creator (ITSE 1430)
 * Jakob Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        static void Main( string[] args )
        {
            int option;
            decimal cart;
            Console.WriteLine("Welcome to the Pizza Creator.");
            do
            {
                DisplayMenu();
                option = SelectOption();
                switch (option)
                {
                    case 1: NewOrder(); break;
                    case 2: ModifyOrder(); break;
                    case 3: DisplayOrder(); break;
                    case 4: 
                    default: Console.WriteLine("Good bye.");
                    System.Threading.Thread.Sleep(1000); // Wait for 1 second before exiting
                    break;
                }
                Console.WriteLine
            } while (option != 4);
        }


        private static void DisplayMenu()
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1 New Order\n" +
                                "2 Modify Order\n" +
                                "3 Display Order\n" +
                                "4 Quit");

        }
        private static int SelectOption()
        {
            var input = Console.ReadLine();
            int option;
            // Check the input. Keep prompting until the user enters 1, 2, 3 or 4.
            while (!Int32.TryParse(input, out option) || (!(option > 0 && option < 5)))
            {
                Console.WriteLine("Error: Your input is invalid. Choose from 1 through 4. ");
                input = Console.ReadLine();
            }
            return option; 
        }

        private static void NewOrder()
        {

        }
        private static void ModifyOrder()
        {

        }
        private static void DisplayOrder()
        {

        }
    }
}
