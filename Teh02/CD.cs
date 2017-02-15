using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh02
{
    class CD
    {
        public string Artisti { get; set; }
        public string Hinta { get; set; }
        public string Biisi { get; set; }

        public override string ToString()
        {
            return "- " + Artisti + "\n- " + Hinta + "\n- " + Biisi;
        }
    }
}
