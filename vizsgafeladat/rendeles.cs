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
