using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5ZADATAK_ponavljanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite URL adresu:");
            string url = Console.ReadLine();

            if(validURL(url))
            {
                Console.WriteLine("URL je tocan.");
            }
            else
            {
                Console.WriteLine("URL nije tocan.");
            }
        }
        string pattern = @"www\..*\.hr$";

        //Pokusao sam rijesiti ali ne razumijem i nije mi skroz tocno//
    }
}
