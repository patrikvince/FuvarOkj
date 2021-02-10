using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("fuvar.csv");
            List<Fuvar> fuvarok = new List<Fuvar>();

            foreach (String sor in sorok.Skip(1))
            {
                fuvarok.Add(new Fuvar(sor));
            }

            Console.WriteLine($"3. feladat: {fuvarok.Count} fuvar");
            

            Console.ReadLine();
        }
    }
}
