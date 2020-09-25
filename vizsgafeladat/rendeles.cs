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
        

        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }




        public rendeles(string tipus,string datum,string sorszam,string email)
        {
            this.tipus = tipus;
            this.datum = datum;
            this.sorszam = sorszam;
            this.email = email;
        }
    }
}
