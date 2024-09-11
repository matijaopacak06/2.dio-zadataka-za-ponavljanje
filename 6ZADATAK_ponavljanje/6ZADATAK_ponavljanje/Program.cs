using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ZADATAK_ponavljanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisi broj clanova redova:");
            int n = int.Parse(Console.ReadLine());
            double suma = 0;

            for (int i = 0; i < n; i++)
            {
                suma += (double)i;
            }
            Console.WriteLine($"Suma reda je:  {suma}");
            
        }
    }
}
