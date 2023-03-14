using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03._2023
{
    public class Loom
    {
        public string Nimi { get; set; }
        public Loom()
        {
        }
        public Loom(string nimi)
        {
            Nimi = nimi;
        }
        public void Loomi_hääl() 
        {
            Console.WriteLine("Auu,auuuu");
        }
    }
}
