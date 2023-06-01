using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dij
    {
        int evszam;
        string tipus;
        string keresztnev;
        string vezeteknev;

        public Dij(string csvSor)
        { 
            string[] mezok = csvSor.Split(';');
            this.evszam = Convert.ToInt32(mezok[0]);
            this.tipus = mezok[1];
            this.keresztnev = mezok[2];
            this.vezeteknev = mezok[3];
        }

        public Dij(int evszam, string tipus, string keresztnev, string vezeteknev)
        {
            this.evszam = evszam;
            this.tipus = tipus;
            this.keresztnev = keresztnev;
            this.vezeteknev = vezeteknev;
        }

        public int Evszam { get => evszam; }
        public string Tipus { get => tipus; }
        public string Keresztnev { get => keresztnev; }
        public string Vezeteknev { get => vezeteknev; }

        public string Nev { get => $"{keresztnev} {vezeteknev}"; }
        public bool Szervezet { get => vezeteknev == ""; }
    }
}
