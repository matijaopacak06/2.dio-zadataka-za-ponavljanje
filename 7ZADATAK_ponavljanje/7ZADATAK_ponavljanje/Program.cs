﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ZADATAK_ponavljanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            for (int i = 2; i < 100; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    count++;
                }
            }

            Console.WriteLine("Broj prim brojeva manjih od 100 je: " + count);
        }
    
    }
}
