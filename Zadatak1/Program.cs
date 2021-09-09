using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StavkaRacuna SRacun1 = new StavkaRacuna("Bananica", 5, 25,Kolicina.komad);
            StavkaRacuna SRacun2 = new StavkaRacuna("Jabuke", 9, 80, Kolicina.kg);
            StavkaRacuna SRacun3 = new StavkaRacuna("Mleko", 2, 100, Kolicina.l);
            Racun Racun1 = new Racun(args[0], SRacun1,true,10);
            Racun Racun2 = new Racun(args[0], SRacun2, false, 0);
            Racun Racun3 = new Racun(args[0], SRacun3, true, 20);


            Console.WriteLine(Racun1.ToString());
            Console.WriteLine(Racun2.ToString());
            Console.WriteLine(Racun3.ToString());



            Console.ReadKey();
        }
    }
}
