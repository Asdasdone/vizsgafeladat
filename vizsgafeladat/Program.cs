using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace vizsgafeladat
{
    class Program
    {
        static List<termek> l = new List<termek>();
        static void beolvas()
        {
            StreamReader ol = new StreamReader("raktar.csv");
            while (!ol.EndOfStream)
            {
                string[] sor = ol.ReadLine().Split(';');
                termek sed = new termek(sor[0],sor[1],int.Parse(sor[2]),int.Parse(sor[3]));
                l.Add(sed);

            }
            ol.Close();
        }
        static void Main(string[] args)
        {

            beolvas();
            Console.WriteLine(l[0].KOD);
            Console.ReadKey();
            
        }
    }
}
