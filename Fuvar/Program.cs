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

            int db = 0;
            double fiz = 0;
            foreach (Fuvar fuvar in fuvarok)
            {
                if (fuvar.ID == 6185)
                {
                    db++;
                    fiz += fuvar.Vitel;
                    fiz += fuvar.Borr;
                }
            }

            Console.WriteLine($"4. feladat: {db} fuvar alatt: {fiz:N2} $");

            Dictionary<string, int> fizetesiModok = new Dictionary<string, int>();
            
            foreach (Fuvar fuvar1 in fuvarok)
            {
                if (fizetesiModok.ContainsKey(fuvar1.Fizm))
                {
                    fizetesiModok[fuvar1.Fizm]++;
                }
                else
                {
                    fizetesiModok.Add(fuvar1.Fizm, 1);
                } 
            }

            Console.WriteLine("5. feladat:");

            foreach (KeyValuePair<string, int> item in fizetesiModok)
            {
                Console.WriteLine($"\t{item.Key}: {item.Value} fuvar");
            }

            double km = 0;
            foreach (Fuvar fuvar2 in fuvarok)
            {
                km += fuvar2.Megtett * 1.6;
            }

            Console.WriteLine($"6. feladat: {km}km");

            double leghosszabb = fuvarok[0].Idotartam;
            int maxInd = 0;
            for (int i = 0; i < fuvarok.Count; i++)
            {
                if (fuvarok[i].Idotartam > leghosszabb)
                {
                    leghosszabb = fuvarok[i].Idotartam;
                    maxInd = i;
                }
            }

            Console.WriteLine("7. feladat: Leghosszabb fuvar:");
            Console.WriteLine($"\tFuvar hossza: {fuvarok[maxInd].Idotartam} masodperc");
            Console.WriteLine($"\tTaxi azonosito: {fuvarok[maxInd].ID}");
            Console.WriteLine($"\tMegtett tavolsag: {fuvarok[maxInd].Megtett:N1}km");
            Console.WriteLine($"\tViteldij: {fuvarok[maxInd].Vitel:N2}$");

            Console.WriteLine("8. feladat: hibak.txt");
            if (File.Exists("hibak.txt"))
            {
                File.Delete("hibak.txt");
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("taxi_id;indulas;idotartam;tavolsag;viteldij;borravalo;fizetes_modja\n");
            foreach (Fuvar fuvar3 in fuvarok)
            {
                if (fuvar3.Idotartam > 0 && fuvar3.Vitel > 0 && fuvar3.Megtett == 0)
                {
                    sb.Append($"{fuvar3.ID}; {fuvar3.Indulas}; {fuvar3.Idotartam}; {fuvar3.Megtett}; {fuvar3.Vitel}; {fuvar3.Borr}; {fuvar3.Fizm}\n");
                }
            }

            File.WriteAllText("hibak.txt", sb.ToString());

            Console.ReadLine();
        }
    }
}
