using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dij> dijak = File.ReadAllLines("nobel.csv").Skip(1).Select(x => new Dij(x)).ToList();

            Console.WriteLine($"3. feladat: {dijak.Find(x => x.Nev == "Arthur B. McDonald").Tipus}");

            Console.WriteLine($"4. feladat: {dijak.Find(x => x.Evszam == 2017 && x.Tipus == "irodalmi").Nev}");

            Console.WriteLine("5. feladat:");
            dijak.Where(x => x.Szervezet && x.Tipus == "béke" && x.Evszam >= 1990).ToList().ForEach(x => Console.WriteLine($"\t{x.Evszam}: {x.Keresztnev}"));

            Console.WriteLine("6. feladat:");
            dijak.Where(x => x.Vezeteknev.Contains("Curie")).ToList().ForEach(x => Console.WriteLine($"\t{x.Evszam}: {x.Nev} ({x.Tipus})"));

            Console.WriteLine("7. feladat:");
            dijak.GroupBy(x => x.Tipus).ToList().ForEach(x => Console.WriteLine($"\t{x.Key,-16}\t{x.Count()} db"));

            File.WriteAllLines("orvosi.txt", dijak.Where(x => x.Tipus == "orvosi").OrderBy(x => x.Evszam).Select(x => $"{x.Evszam}:{x.Nev}"));
        }
    }
}
