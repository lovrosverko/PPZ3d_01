using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPZ3d_01_04
{
    internal class Program
    {
        /*
         * Napišite program koji će za definirani niz tipa double 
         * pronaći član koji najmanje odstupa od prosječne vrijednosti niza. 
         * Program mora raditi ispravno za proizvoljni broj članova niza.
        */

        static void Main(string[] args)
        {
            double[] arr = { 1.5, 2.3, 3.6, 4.8, 5.2, 6.9, 7.4 };
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i + 1;
                Console.WriteLine("{0} član niza: {1}", j, arr[i]);
                sum += arr[i];
            }
            double prosjek = sum / arr.Length;
            Console.WriteLine("Prosječna vrijednost niza: {0}", prosjek);
            int indeks = 0;
            double minimalnaRazlika = sum; // Bitno je da minimalnaRazlika bude veća od očekivane
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i] - prosjek) < minimalnaRazlika)
                {
                    minimalnaRazlika = Math.Abs(arr[i] - prosjek);
                    indeks = i;
                }
            }
            Console.WriteLine("Član koji najmanje odstupa od prosječne vrijednosti niza: {0}"
                , arr[indeks]);
            Console.ReadKey(); 
        }
    }
}
