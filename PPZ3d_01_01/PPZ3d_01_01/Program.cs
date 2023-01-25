using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPZ3d_01_01
{
    internal class Program
    {
        /*
         * Napišite program u kojem ćete zatražiti 
         * od korisnika da unese niz znakova te će 
         * svaki razmak zamijeniti znakom '_'
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Unesite niz znakova:");
            string s = Console.ReadLine();
            s = s.Replace(' ', '_');
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
