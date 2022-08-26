// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HEllo");
            int i = 0;
            int max = 100;
            int f = 3;
            int b = 5;

            while (i <= max)
            {
                if (i % f == 0 && i % b == 0)
                {
                    Console.WriteLine(i + " Fuzz Buzz");
                }
                  if (i % f == 0)
                  {
                      Console.WriteLine(i + " Fuzz");
                  }
                    else if (i % b == 0)
                    {
                        Console.WriteLine( i + " Buzz");
                    }
                      else
                      {
                    Console.WriteLine(i);
                      }        
              
                i++;
               
            }

        }
    }
}