using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notitieboekje
{
    class Notitieboekje
    {
        private Notitie[] notities;
        private int notitieTeller = 0;
        private int length = 10;

        private bool laminated = false; 

        private string eigenaar;
        private ConsoleColor kleur;
        private string titel;

        public Notitieboekje(string eigenaar, ConsoleColor kleur, string titel)
        {
            this.eigenaar = eigenaar;
            this.kleur = kleur;
            this.titel = titel;
            notities = new Notitie[length];
        }

        /// <summary>
        /// -1 is boek vol, -2 is notitie is null, -3 laminated
        /// </summary>
        /// <param name="opschrift">Wat moet er op de notitie staan</param>
        /// <returns></returns>
        public int Bijschrijven(string opschrift)
        {
            if (laminated)
                return -3;

            if (string.IsNullOrEmpty(opschrift))
            {
                return -2;
            }

            for (int i = 0; i < length; i++)
            {
                if (notities[i] == null)
                {
                    notities[i] = new Notitie(opschrift);
                    return ++notitieTeller;
                }
            }

            return -1;
        }

        public string BekijkNotities()
        {
            string terug = $"{notitieTeller} notities van de {notities.Length}\n";

            for (int i = 0; i < notitieTeller; i++)
            {
                terug += $"{i + 1}. {notities[i].Bekijk()}.\n";
            }

            return terug;
        }

        public string BekijkNotitie(int index)
        {
            string terug = "";

            if (notitieTeller != 0)
            {
                if (index <= notitieTeller)
                {
                    terug = $"Je bekijkt de notitie... Er staat \"{notities[index].Bekijk()}\" op geschreven.";
                }
            }
            return terug;
        }

        public void Uitscheuren(int pagina)
        {
            if (laminated)
                return;

            for (int i = pagina; i < length - 1; i++)
            {
                notities[i] = notities[i + 1];
            }

            notities[length - 1] = null;
            notitieTeller--;
            length--;
        }

        public void BekijkEigenschappen()
        {
            Console.ForegroundColor = kleur;
            Console.WriteLine($"Dit is {eigenaar} zijn/haar notitieboekje. Er zitten {length} pagina's in waarvan {notitieTeller} ingevuld. De titel is {titel}.");
            Console.ResetColor();
        }

        public void Lamineren()
        {
            laminated = true;
        }
    }
}
