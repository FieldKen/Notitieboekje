using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notitieboekje
{
    class Notitie
    {
        private string opschrift;
        private DateTime datum = DateTime.UtcNow;

        public string Opschrift
        {
            get { return opschrift; }
            set { opschrift = value; }
        }

        public Notitie(string nieuwOpschrift)
        {
            opschrift = nieuwOpschrift;
        }

        public string Bekijk()
        {
            return $"{datum:dddd MM yyyy HH:mm}:  {opschrift}";
        }
    }
}