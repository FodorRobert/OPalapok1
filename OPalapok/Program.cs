using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPalapok
{

    public class Szemely
    {

        private string nev;
        private int kor;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public int Kor
        {
            get { return kor; }
            set { kor = value; }
        }

        /*
        public Szemely(string nev, int kor)
        {



        }

        public string kiir()
        {

            return $"A tanulo neve: {nev} és {kor} éves";

        }
        */

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Szemely tanulo1 = new Szemely();
            tanulo1.Nev = "Gábor";
            Console.WriteLine(tanulo1.Nev);
            tanulo1.Kor = 23;
            Console.WriteLine(tanulo1.Kor);

            /*
            Szemely tanulo1 = new Szemely("Jani", 55);
            Console.WriteLine(tanulo1.kiir());
            Szemely tanulo2 = new Szemely("Ildi", 45);
            Console.WriteLine(tanulo2.kiir());
            */

        }
    }
}
