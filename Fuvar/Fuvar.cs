using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar
{
    class Fuvar
    {

        public Fuvar(string sor)
        {
            string[] s = sor.Split(';');
            ID = int.Parse(s[0]);
            Indulas = s[1];
            Idotartam = int.Parse(s[2]);
            Megtett = double.Parse(s[3]);
            Vitel = double.Parse(s[4]);
            Borr = double.Parse(s[5]);
            Fizm = (s[6]);
        }

        public int ID { get;  }
        public string Indulas { get;  }
        public int Idotartam { get;  }
        public double Megtett { get;  }
        public double Vitel { get;  }
        public string Fizm { get; }
        public double Borr { get; }
    }
}
