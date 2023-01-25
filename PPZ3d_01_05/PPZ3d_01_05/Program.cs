using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPZ3d_01_05
{
    /*
     * Definirajte klasu NebeskoTijelo sa sljedećim varijablama članicama:
     *  • varijable tipa double
     *      BrzinaOkoOsi 
     *      BrzinaOkoSunca 
     * Definirajte klase Planet i Satelit izvedene iz klase NebeskoTijelo
     * te im definirajte sljedeće konstruktore:
     *      Planet(double, double)
     *      Satelit(double, double) 
     * koji će dodijeliti vrijednosti proslijeđenih argumenata naslijeđenim
     * varijablama članicama.
     * Definirajte dva objekta Zemlja i Mjesec tipova Planet i Satelit.
     */
    class NebeskoTijelo
    {
        protected double BrzinaOkoOsi;
        protected double BrzinaOkoSunca;
    }
    class Planet : NebeskoTijelo
    {
        public Planet(double d1, double d2)
        {
            BrzinaOkoOsi = d1;
            BrzinaOkoSunca = d2;
        }
    }
    class Satelit : NebeskoTijelo
    {
        public Satelit(double d1, double d2)
        {
            BrzinaOkoOsi = d1;
            BrzinaOkoSunca = d2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Planet Zemlja = new Planet(1000, 2000);
            Satelit Mjesec = new Satelit(100, 200);
        }
    }
}
