using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobbagymate
{
    class Bolygok
    {
        public string BolygoNev { get; set; }
        public int HoldDB { get; set; }
        public string Terfogat { get; set; }

        public Bolygok(string r)
        {
            var v = r.Split(';');
            BolygoNev = v[0];
            HoldDB = int.Parse(v[1]);
            Terfogat = v[2];
        }
    }
}
