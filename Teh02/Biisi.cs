using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh02
{
    class Biisi
    {
        public string Nimi { get; set; }
        public string Pituus { get; set; }

        public override string ToString()
        {
            return "- " + Nimi + ", " + Pituus;
        }
    }
}
