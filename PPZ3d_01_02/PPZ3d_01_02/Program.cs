using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPZ3d_01_02
{
    /*
     * Napišite program koji će zatražiti od korisnika 
     * da unese dva stringa, te će ih ispisati po
     * abecedi u uzlaznom redoslijedu.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prvi string:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Unesite drugi string:");
            string s2 = Console.ReadLine();
            if (s1.CompareTo(s2) > 0)
            {
                Console.WriteLine(s2);
                Console.WriteLine(s1);
            }
            else
            {
                Console.WriteLine(s1);
                Console.WriteLine(s2);
            }

            Console.ReadKey();
        }
    }
}
