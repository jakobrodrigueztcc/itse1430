﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main( string[] args )
        {
            string name;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Hello ");
            Console.WriteLine(name);

            string message = "Hello" + "hey";
            Console.WriteLine(message);
        }
    }
}
