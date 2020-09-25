using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsgafeladat
{
    class rendeles
    {
        private string tipus, datum, sorszam, email;
        

        public string TIPUS
        {
            get { return tipus; }
            set { tipus = value; }
        }
        

        public string DATUM
        {
            get { return datum; }
            set { datum = value; }
        }
        

        public string SORSZAM
        {
            get { return sorszam; }
            set { sorszam = value; }
        }

        private List<tetel> asd;

        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }

        public void tetelad(string a,int b)
        {
            tetel sed = new tetel(a,b);
            asd.Add(sed);

        }
        public void kiir()
        {
            foreach (var item in asd)
            {
                Console.WriteLine(item.KOD+";"+item.DB);
            }
        }
        private int osszeg;

        public int OSSZEG
        {
            get { return osszeg; }
            set { osszeg = value; }
        }
        public void ossz(List<termek> termeks)
        {
            int szum=0;
            for (int i = 0; i < termeks.Count; i++)
            {
                int ar = are(asd[i].KOD,termeks);
                szum += ar * asd[i].DB;
            }

        }
        public int are(string kod,List<termek>termeks)
        {
            int i = 0;
            while (kod!=termeks[i].KOD)// && i<termeks.Count)
            {
                i++;
            }
            //if (i<termeks.Count)
            //{
                return termeks[i].AR;
            //}
            //else
            //{
              //  return -1;
            //}
           
        }


        public rendeles(string tipus,string datum,string sorszam,string email)
        {
            this.tipus = tipus;
            this.datum = datum;
            this.sorszam = sorszam;
            this.email = email;
            asd = new List<tetel>();
        }
    }
}
