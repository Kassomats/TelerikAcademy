﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string inputChanged = input.PadRight(20, '*');
            Console.WriteLine(inputChanged);
        }
    }
}
