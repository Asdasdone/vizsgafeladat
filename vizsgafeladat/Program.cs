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
        static void beolvas()
        {
            StreamReader ol = new StreamReader("raktar.csv");
            while (!ol.EndOfStream)
            {
                string[] sor = ol.ReadLine().Split(';');
                Console.WriteLine(sor[0]);
            }
            ol.Close();
        }
        static void Main(string[] args)
        {

            beolvas(); 
            Console.ReadKey();
            
        }
    }
}
