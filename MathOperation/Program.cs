﻿using System;

namespace MathOperation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MathOperations mo = new MathOperations();
            Console.WriteLine("\nOutput:\n");
            
            Console.WriteLine(mo.Add(2, 3));
            Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));


            Console.WriteLine("Any key to Quit!");
            Console.ReadLine();
        }
    }
}
