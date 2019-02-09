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
            Console.ForegroundColor = ConsoleColor.Yellow;
            /*Console.BackgroundColor = ConsoleColor.DarkYellow;*/
            PizzaOrder order = new PizzaOrder();
            int option;
            bool orderExists = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Pizza Creator\n"
                                + "-----------------------\n"
                                + "Total\t\t" + order.CalculatePrice() + "\n"
                                + "-----------------------\n");
                DisplayMenu();
                option = SelectOption();
                Console.Clear();
                switch (option)
                {
                    case 1: if (NewOrder(orderExists))
                            {
                                order.ResetOrder();
                                order.MakeOrder();
                                order.DisplayOrder();
                                orderExists = true;
                            }
                        break;
                    case 2: if (ModifyOrder(orderExists))
                            {
                                order.MakeOrder();
                                order.DisplayOrder();
                            }
                        break;
                    case 3: if(DisplayOrder(orderExists))
                                order.DisplayOrder();
                        break;
                    case 4: // fall to default
                    default: Console.WriteLine("Good bye.");
                        System.Threading.Thread.Sleep(1000); // Wait for 1 second before exiting
                        break;
                }
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
            int option;
            var input = Console.ReadLine();
            // Check the input. Keep prompting until the user enters 1, 2, 3 or 4.
            while (!Int32.TryParse(input, out option) || (!(option > 0 && option < 5)))
            {
                Console.WriteLine("ERROR: Your input is invalid. Choose from 1, 2, 3 or 4. ");
                input = Console.ReadLine();
            }
            return option; 
        }

        private static bool NewOrder(bool orderExists)
        {
            Console.Clear();
            Console.WriteLine("PLACE A NEW ORDER - \n" +
                              "-------------------"); //If no order already exists then the user starts creating a new order.


            string input = "";
            if (orderExists == true)
            {
                Console.WriteLine("An order already exists. Would you like to overwrite the existing order? Y/N");
                input = Console.ReadLine();
                while (String.IsNullOrWhiteSpace(input))
                {
                    input = Console.ReadLine();
                }
                    if (input.Trim().Substring(0, 1).ToUpper() == "Y")
                        return true;
                    else
                        return false;
            }

                return true;
        }
        private static bool ModifyOrder(bool orderExists)
        {
            Console.Clear();
            Console.WriteLine("MODIFY YOUR ORDER - \n" +
                              "-------------------");

            if (orderExists == false)
            {
                Console.WriteLine("There is no order to modify.");
                System.Threading.Thread.Sleep(2000);
                return false;
            }
            else //Modify order
                return true;

        }
        private static bool DisplayOrder(bool orderExists)
        {
            Console.Clear();
            Console.WriteLine("VIEW YOUR ORDER - \n" +
                              "-------------------");

            if (orderExists == false)
            {
                Console.WriteLine("There is no order to display.");
                System.Threading.Thread.Sleep(2000);
                return false;
            }
            else //print out order specifics
                return true;

        }
    }

    class PizzaOrder
    {
        private static decimal totalPrice = 0.00M;
        // "Choose one"
        private static int size = 0;
        private static int sauce = 0;
        private static int cheese = 0;
        private static int delivery = 0;
        // Toppings - meats
        private static bool bacon = false;
        private static bool ham = false;
        private static bool pepperoni = false;
        private static bool sausage = false;
        // Toppings - vegetables
        private static bool olives = false;
        private static bool mushrooms = false;
        private static bool onions = false;
        private static bool peppers = false;
        // Prices
        private const decimal sizeSmall = 5.00M;
        private const decimal sizeMedium = 6.25M;
        private const decimal sizeLarge = 8.75M;
        private const decimal toppingMeat = 0.75M; // bacon; ham; pepperoni; sausage
        private const decimal toppingVeggie = 0.50M; // black olives; mushrooms; onions; peppers
        private const decimal regular = 0.00M; // TOPPINGS: none; SAUCE: traditional; CHEESE: regular; DELIVERY: take out
        private const decimal sauceOther = 1.00M; // garlic; oregano
        private const decimal cheeseExtra = 0.50M;
        private const decimal deliveryCost = 2.50M;

        public void ResetOrder()
        {
            totalPrice = 0.00M;
            size = 0;
            sauce = 0;
            cheese = 0;
            delivery = 0;
            bacon = false;
            ham = false;
            pepperoni = false;
            sausage = false;
            olives = false;
            mushrooms = false;
            onions = false;
            peppers = false;

        }
        public string CalculatePrice()
        {
            totalPrice = 0;
            switch (size)
            {
                case 1: totalPrice += sizeSmall; break;
                case 2: totalPrice += sizeMedium; break;
                case 3: totalPrice += sizeLarge; break;
                default: break;
            }
            switch (delivery)
            {
                case 1: totalPrice += regular; break;
                case 2: totalPrice += deliveryCost; break;
                default: break;
            }
            switch (sauce)
            {
                case 1: totalPrice += regular; break;
                case 2: //Garlic & Oregano
                case 3: totalPrice += sauceOther; break;
                default: break;
            }
            switch (cheese)
            {
                case 1: totalPrice += regular; break;
                case 2: totalPrice += cheeseExtra; break;
                default: break;
            }

            if (bacon) totalPrice += toppingMeat;
            if (ham) totalPrice += toppingMeat;
            if (pepperoni) totalPrice += toppingMeat;
            if (sausage) totalPrice += toppingMeat;
            
            if (olives) totalPrice += toppingVeggie;
            if (mushrooms) totalPrice += toppingVeggie;
            if (onions) totalPrice += toppingVeggie;
            if (peppers) totalPrice += toppingVeggie;

            return totalPrice.ToString("C2");
        }
        public void MakeOrder()
        {
            Console.Clear();
            int option;
            Console.WriteLine("Choose a size for your pizza:\n1 Small Pizza\n2 Medium Pizza\n3 Large Pizza");
            if(size != 0) Console.WriteLine("\nSELECTED: " + size);

            option = getInput(1, 3);
            if (option == 1) { size = 1; }
            else if (option == 2) { size = 2; }
            else if (option == 3) { size = 3; }

            Console.Clear();
            Console.WriteLine("Choose a sauce:\n1 Traditional\n2 Garlic\n3 Oregano");
            if (sauce != 0) Console.WriteLine("\nSELECTED: " + sauce);

            option = getInput(1, 3);
            if (option == 1) { sauce = 1; }
            else if (option == 2) { sauce = 2; }
            else if (option == 3) { sauce = 3; }

            string currentToppings;
            while (option != 5)
            {
                Console.Clear();
                Console.WriteLine("Select meat toppings:\n1 Bacon\n2 Ham\n3 Pepperoni\n4 Sausage\n" +
                                 "Uselect an option by entering it again. Press 5 to continue.");

                currentToppings = "";
                if (bacon) currentToppings += " > Bacon";
                if (ham) currentToppings += " > Ham";
                if (pepperoni) currentToppings += " > Pepperoni";
                if (sausage) currentToppings += " > Sausage";
                if (!bacon && !ham && !pepperoni && !sausage) currentToppings += " NONE";
                Console.WriteLine("\nSELECTED: " + currentToppings);

                option = getInput(1, 5);
                if (option == 1) bacon = !bacon;
                else if (option == 2) ham = !ham;
                else if (option == 3) pepperoni = !pepperoni;
                else if (option == 4) sausage = !sausage;
            }
            option = 0;
            while (option != 5)
            {
                Console.Clear();
                Console.WriteLine("Select vegetable toppings:\n1 Black olives\n2 Mushrooms\n3 Onions\n4 Peppers\n" +
                                 "Uselect an option by entering it again. Press 5 to continue.");

                currentToppings = "";
                if (olives) currentToppings += " > Black olives";
                if (mushrooms) currentToppings += " > Mushrooms";
                if (onions) currentToppings += " > Onions";
                if (peppers) currentToppings += " > Peppers";
                if (!olives && !mushrooms && !onions && !peppers) currentToppings += " NONE";
                Console.WriteLine("\nSELECTED: " + currentToppings);

                option = getInput(1, 5);
                if (option == 1) olives = !olives;
                else if (option == 2) mushrooms = !mushrooms;
                else if (option == 3) onions = !onions;
                else if (option == 4) peppers = !peppers;
            }

            Console.Clear();
            Console.WriteLine("Choose amount of cheese:\n1 Regular\n2 Extra");
            if (cheese != 0) Console.WriteLine("\nSELECTED: " + cheese);

            option = getInput(1, 2);
            if (option == 1) { cheese = 1; }
            else if (option == 2) { cheese = 2; }

            Console.Clear();
            Console.WriteLine("Delivery method:\n1 Take Out\n2 Delivery");
            if (delivery != 0) Console.WriteLine("\nSELECTED: " + delivery);

            option = getInput(1, 2);
            if (option == 1) { delivery = 1; }
            else if (option == 2) { delivery = 2; }


        }

        public void DisplayOrder()
        {
            Console.Clear();
            string receipt = "";

            switch (size)
            {
                case 1: receipt += "Small Pizza\t" + sizeSmall.ToString("C2") + "\n"; break;
                case 2: receipt += "Medium Pizza\t" + sizeMedium.ToString("C2") + "\n"; break;
                case 3: receipt += "Large Pizza\t" + sizeLarge.ToString("C2") + "\n"; break;
                default: break;
            }
            switch (cheese)
            {
                case 1: break;
                case 2: receipt += "Extra Cheese\t" + cheeseExtra.ToString("C2") + "\n"; break;
                default: break;
            }
            switch (delivery)
            {
                case 1: receipt += "Take Out\n"; break;
                case 2: receipt += "Delivery\t" + deliveryCost.ToString("C2") + "\n"; break;
                default: break;
            }
            if (bacon || ham || pepperoni || sausage)
            {
                receipt += "Meats";
                if (bacon) receipt += "\n   " + "Bacon\t" + toppingMeat.ToString("C2");
                if (ham) receipt += "\n   " + "Ham\t" + toppingMeat.ToString("C2");
                if (pepperoni) receipt += "\n   " + "Pepperoni\t" + toppingMeat.ToString("C2");
                if (sausage) receipt += "\n   " + "Sausage\t" + toppingMeat.ToString("C2");
                receipt += "\n";
            }
            if (olives || mushrooms || onions || peppers)
            {
                receipt += "Vegetables";
                if (olives) receipt += "\n   " + "Olives\t" + toppingVeggie.ToString("C2");
                if (mushrooms) receipt += "\n   " + "Mushrooms\t" + toppingVeggie.ToString("C2");
                if (onions) receipt += "\n   " + "Onions\t" + toppingVeggie.ToString("C2");
                if (peppers) receipt += "\n   " + "Peppers\t" + toppingVeggie.ToString("C2");
                receipt += "\n";
            }

            receipt += "Sauce";
            switch (sauce)
            {
                case 1: receipt += "\n   " + "Traditional"; break;
                case 2: receipt += "\n   " + "Oregano\t" + sauceOther.ToString("C2"); break;
                case 3: receipt += "\n   " + "Garlic\t" + sauceOther.ToString("C2"); break;
                default: break;
            }

            receipt += "\n----------------------\n"
                      + "Total\t\t" + CalculatePrice();
            Console.WriteLine(receipt);

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadLine();
        }

        public int getInput(int rangeStart, int rangeEnd)
        {

            var input = "";
            var option = 0;
            input = Console.ReadLine();
            Int32.TryParse(input, out option);
            while(String.IsNullOrWhiteSpace(input) || !Int32.TryParse(input, out option) || (option < rangeStart || option > rangeEnd))
            {
                Console.WriteLine("ERROR: Choose from " + rangeStart + "-" + rangeEnd + ".");
                input = Console.ReadLine();
            }
            Int32.TryParse(input.Trim().Substring(0, 1), out option);
            return option;
        }

        public bool toggleTopping(bool topping)
        {
            topping = !topping;
            return topping;
        }
    }
    
}
