﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsgafeladat
{
    class termek
    {
		private string kod;

		public string KOD
		{
			get { return kod; }
			set { kod = value; }
		}
		private string nev;

		public string NEV
		{
			get { return nev; }
			set { nev = value; }
		}
		private int db;

		public int DB
		{
			get { return db; }
			set { db = value; }
		}
		private int ar;

		public int AR
		{
			get { return ar; }
			set { ar = value; }
		}

		public termek(string kod, string nev,int ar,int db)
		{
			this.kod = kod;
			this.nev = nev;
			this.ar = ar;
			this.db = db;
		}


	}
}
