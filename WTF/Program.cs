﻿using System;

namespace WTF
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertCodeHere theCode = new InsertCodeHere();
            theCode.MyCode();

            Console.WriteLine(theCode.ToString());
            Console.WriteLine("Press any key to close the program...");

            Console.ReadKey();
        }
    }
}
