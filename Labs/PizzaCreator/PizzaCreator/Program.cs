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
        public static decimal totalPrice = 0.00M; // make totalPrice readable by the entire class.

        static void Main( string[] args )
        {
            int option;
            Console.WriteLine("Welcome to the Pizza Creator.");
            do
            {
                DisplayMenu();
                option = SelectOption();
                switch (option)
                {
                    case 1: totalPrice = NewOrder(); break;
                    case 2: totalPrice = ModifyOrder(); break;
                    case 3: totalPrice = DisplayOrder(); break;
                    case 4: //case falls through to default.
                    default: Console.WriteLine("Good bye.");
                    System.Threading.Thread.Sleep(1000); // Wait for 1 second before exiting
                    break;
                }
                CalculatePrice();
                Console.WriteLine();
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
                Console.WriteLine("ERROR: Your input is invalid. Choose from 1, 2, 3 or 4. ");
                input = Console.ReadLine();
            }
            return option; 
        }

        private static decimal NewOrder()
        {
            
            Console.WriteLine("PLACE A NEW ORDER - "); //If no order already exists then the user starts creating a new order.

            decimal newTotal = totalPrice;
            return newTotal;
        }
        private static decimal ModifyOrder()
        {
            Console.WriteLine("MODIFY YOUR ORDER - ");

            decimal newTotal = totalPrice;
            return newTotal;

        }
        private static decimal DisplayOrder()
        {
            Console.WriteLine("VIEW YOUR ORDER - ");

            decimal newTotal = totalPrice;
            return newTotal;

        }

        private static void CalculatePrice()
        {
            Console.WriteLine(totalPrice.ToString("C2")); //Format totalPrice into currency ($) with 2 decimal places.
            Console.WriteLine();
        }
    }
}
