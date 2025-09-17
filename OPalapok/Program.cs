using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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
            return $"A személy neve {nev} életkora {kor}.";
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

        public string neptunKod;

        public string NeptunKod
        {
            get { return neptunKod; }
            set 
            {
                if (value.Length <= 6)
                    neptunKod = value;
                else
                    Console.WriteLine("Nem megfelelő hosszúság");
            }
        }

        public void kiir()
        {
            nev = string.Empty;
        }

    }

    public class Dolgozo : Szemely
    {

        public int Ber;

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Szemely tanulo1 = new Szemely();
            tanulo1.Nev = "Gábor";
            tanulo1.Kor = 23;
            Console.WriteLine(tanulo1);
            Console.WriteLine("-----------------------------------------------------");

            Bankszamla bankszamla1 = new Bankszamla();
            bankszamla1.Egyenleg = 5700;
            Console.WriteLine(bankszamla1.Egyenleg);
            Console.WriteLine("-----------------------------------------------------");

            Hallgato hallgato1 = new Hallgato();
            hallgato1.neptunKod = "MHWLN9";
            Console.WriteLine(hallgato1.neptunKod);
            Console.WriteLine("-----------------------------------------------------");

            List<Hallgato> hallgatok = new List<Hallgato>();
            for (int i = 0; i < 2; i++)
            {
                Hallgato hallgato = new Hallgato();
                Console.WriteLine($"Kérem a(z) {i + 1} hallgato nevét: ");
                hallgato.Nev = Console.ReadLine();
                Console.WriteLine($"Kérem a(z) {i + 1} hallgato életkorát: ");
                hallgato.Kor = int.Parse( Console.ReadLine() );
                Console.WriteLine($"Kérem a(z) {i + 1} hallgato neptunkódját: ");
                hallgato.NeptunKod = Console.ReadLine();
                hallgatok.Add(hallgato);
            }
            Console.WriteLine($"A hallgatók neve: ");
            foreach(var item in hallgatok)
            {
                Console.WriteLine(item.Nev);
            }

            /*
            Szemely tanulo1 = new Szemely("Jani", 55);
            Console.WriteLine(tanulo1.kiir());
            Szemely tanulo2 = new Szemely("Ildi", 45);
            Console.WriteLine(tanulo2.kiir());
            */

        }
    }
}
