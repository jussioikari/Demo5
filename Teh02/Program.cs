using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CD data: ");
            List < CD > cd = new List<CD>();

            cd.Add(new CD { Artisti = "Nightwish", Hinta = "19.90e", Biisi = "Biisit"});

            Console.WriteLine(cd.ElementAt(0).ToString());

            List<Biisi> biisit = new List<Biisi>();

            biisit.Add(new Biisi { Nimi = "Shudder Before the Beautiful", Pituus = "6:29" });
            biisit.Add(new Biisi { Nimi = "Weak Fantasy", Pituus = "5:23" });
            biisit.Add(new Biisi { Nimi = "Elan", Pituus = "4:45" });
            biisit.Add(new Biisi { Nimi = "Yours Is an Empty Hope", Pituus = "5:34" });
            biisit.Add(new Biisi { Nimi = "Our Decades in the Sun", Pituus = "6:37" });
            biisit.Add(new Biisi { Nimi = "My Walden", Pituus = "4:38" });
            biisit.Add(new Biisi { Nimi = "Endless Forms Most Beautiful", Pituus = "5:07" });
            biisit.Add(new Biisi { Nimi = "Edema Ruh", Pituus = "5:15" });
            biisit.Add(new Biisi { Nimi = "Alpenglow", Pituus = "4:45" });
            biisit.Add(new Biisi { Nimi = "The Eyes of Sharbat Gula", Pituus = "6:03" });
            biisit.Add(new Biisi { Nimi = "The Greatest Show on Earth", Pituus = "24:00" });

            Console.WriteLine(biisit.ElementAt(0).ToString());

            foreach (Biisi biisi in biisit)
            {
                Console.WriteLine(biisi.ToString());
            }
        }
    }
}
