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
                
                l.Add(new termek(sor[0], sor[1], int.Parse(sor[2]), int.Parse(sor[3])));

            }
            ol.Close();
        }
        static void Main(string[] args)
        {

             beolvas();
             for (int i = 0; i < l.Count; i++)
             {
                 Console.WriteLine($"{l[i].KOD},{l[i].NEV},{l[i].AR},{l[i].DB}");
             }

            
            Console.ReadKey();
            
        }
    }
}
