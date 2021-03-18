using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notitieboekje
{
    class Program
    {
        static void Main(string[] args)
        {
            Notitieboekje boek = new Notitieboekje("Ken", ConsoleColor.Green, "Mijn dagboek");
            boek.Bijschrijven("Hello world!");
            boek.Bijschrijven("Tweede pagina");
            boek.Bijschrijven("Derde pagina");
            boek.Bijschrijven("Vierde pagina");
            boek.Bijschrijven("Vijfde pagina");
            boek.Bijschrijven("Zesde pagina");
            boek.Bijschrijven("Zevende pagina");
            boek.Bijschrijven("Achtste pagina");
            boek.Bijschrijven("Negende pagina");
            boek.Bijschrijven("Tiende pagina");
            boek.Bijschrijven("Elfde pagina");
            boek.Bijschrijven("Twaalfde pagina");

            Console.WriteLine(boek.BekijkNotitie(2));
            boek.Uitscheuren(0);
            boek.Bijschrijven("Nieuwe pagina");
            boek.Bijschrijven("Nieuwe pagina 2");
            Console.WriteLine(boek.BekijkNotities());
            boek.Lamineren();

            boek.BekijkEigenschappen();

            Console.ReadLine();
        }
    }
}
