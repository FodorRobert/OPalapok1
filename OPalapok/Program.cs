using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPalapok
{

    public class Szemely
    {

        public string nev = "Peti";
        public int kor = 34;

        public Szemely(string nev, int kor)
        {



        }

        public string kiir()
        {

            return $"A tanulo neve: {nev} és {kor} éves";

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Szemely tanulo1 = new Szemely("Jani", 55);
            Console.WriteLine(tanulo1.kiir());
            Szemely tanulo2 = new Szemely("Ildi", 45);
            Console.WriteLine(tanulo2.kiir());
        }
    }
}
