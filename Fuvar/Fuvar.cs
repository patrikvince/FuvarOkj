using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar
{
    class Fuvar
    {
        private int id, idotartam;
        private string indulas, fizm;
        private double megtett, vitel, borr; 

        public Fuvar(string sor)
        {
            string[] s = sor.Split(';');
            this.id = int.Parse(s[0]);
            this.indulas = s[1];
            this.idotartam = int.Parse(s[2]);
            this.megtett = double.Parse(s[3]);
            this.vitel = double.Parse(s[4]);
            this.borr = double.Parse(s[5]);
            this.fizm = (s[6]);
        }
    }
}
