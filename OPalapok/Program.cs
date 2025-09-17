using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPalapok
{

    public class Szemely
    {

        private protected string nev;
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

        public override string ToString()
        {
            return $"A szeély neve {nev} életkora {kor}.";
        }

        /*
        public Szemely(string nev, int kor)
        {

            nev = Nev;
            kor = Kor;

        }

        public string kiir()
        {

            return $"A tanulo neve: {nev} és {kor} éves";

        }
        */

    }

    public class Bankszamla
    {

        private int egyenleg;
        public int Egyenleg
        {
            get { return egyenleg; }
            set 
            {
                if (value >= 0)
                    egyenleg = value;
                else
                    Console.WriteLine("Az érték nem lehet negatív");
            }
        }

        /*
        private void Betesz()
        {

        }

        private void Kivesz()
        {

        }
        */

    }

    public class Hallgato : Szemely
    {

        public int neptunKod;

        public string nev
        {
            get { return nev; }
            set { nev = value; }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Szemely tanulo1 = new Szemely();
            tanulo1.Nev = "Gábor";
            tanulo1.Kor = 23;
            Console.WriteLine(tanulo1);

            Bankszamla bankszamla1 = new Bankszamla();
            bankszamla1.Egyenleg = 5700;
            Console.WriteLine(bankszamla1.Egyenleg);

            /*
            Szemely tanulo1 = new Szemely("Jani", 55);
            Console.WriteLine(tanulo1.kiir());
            Szemely tanulo2 = new Szemely("Ildi", 45);
            Console.WriteLine(tanulo2.kiir());
            */

        }
    }
}
