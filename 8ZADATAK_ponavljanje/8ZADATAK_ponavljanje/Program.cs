using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8ZADATAK_ponavljanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("n-ti član Fibonaccijevog niza je: {Fibonacci(n)}");
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
            Console.ReadKey();
        }
      

    }
}
