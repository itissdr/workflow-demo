using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the master Branch");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Count: " + i.ToString());
            }
        }
    }
}
