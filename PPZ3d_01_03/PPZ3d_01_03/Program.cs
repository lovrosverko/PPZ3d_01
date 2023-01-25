using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPZ3d_01_03
{
    /*
     * Fibonaccijev niz definiran je na sljedeći način: 
     *      • prvi član niza je 0
     *      • drugi član niza je 1
     *      • svaki sljedeći član niza jednak je zbroju prethodna dva člana
     * Napišite program koji će zatražiti od korisnika da unese broj n
     * te će izračunati n-ti član Fibonaccijevog niza.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Upišite neki broj:");
            string s = Console.ReadLine();
            n = Convert.ToInt32(s);
            int x1 = 0, x2 = 1, fib;
            if (n == 1)
                fib = 0;
            else if (n == 2)
                fib = 1;
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(
                        "{0}. član Fibonnacijevog niza je {1}", i + 1, x1);
                    int y = x1 + x2;
                    x1 = x2;
                    x2 = y;
                    
                }
                fib = x1;
                
            }
            Console.WriteLine(
            "{0}. član Fibonnacijevog niza je {1}", n, fib);

            Console.ReadKey();
        }
    }
}
