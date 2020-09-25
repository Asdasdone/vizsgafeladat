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
        static List<rendeles> rend = new List<rendeles>();
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
        static void rendelol()
        {
            StreamReader ol = new StreamReader("rendeles.csv");
            while (!ol.EndOfStream)
            {
                string sor = ol.ReadLine();
                string[] ads = sor.Split(';');
                

                if (ads[0]=="M")
                {
                   rend.Add(new rendeles(ads[0], ads[1], ads[2], ads[3])); 
                }
                else
                {
                    rend[rend.Count - 1].tetelad(ads[2],int.Parse(ads[3]));
                }

                

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
            rendelol();
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine($"{rend[i].DATUM};{rend[i].SORSZAM};{rend[i].EMAIL}");
                rend[i].kiir();
            }
            Console.ReadKey();
            
        }
    }
}
