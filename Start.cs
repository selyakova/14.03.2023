using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03._2023
{
    public class Start
    {
        public static void Main(string[] args)
        {
            Dictionary<int,string> riigid = new Dictionary<int,string>(5);
            riigid.Add(1, "Eesti");
            riigid.Add(2, "Norra");
            riigid.Add(3, "Soome");
            riigid.Add(4, "Prantsusmaa");
            riigid.Add(5, "Saksamaa");
            foreach (KeyValuePair<int,string> item in riigid)
            {
                Console.WriteLine(item.Key+") "+item.Value);
            }


            Loom loom1= new Loom();
            loom1.Nimi = "Holly";
            Console.Write(loom1.Nimi+" rägib: ");
            loom1.Loomi_hääl();
            Loom loom2= new Loom("Rudy");
            loom1.Nimi = "Gudi";

            Console.Write(loom1.Nimi + " rägib: ");
            loom1.Loomi_hääl();
            Console.Write(loom2.Nimi + " rägib: ");
            loom2.Loomi_hääl();


            Dictionary<int, Loom> loomad = new Dictionary<int, Loom>(4);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Looma nimi: ");
                loomad.Add(i + 1, new Loom() { Nimi = Console.ReadLine() });
                {
                    foreach (Loom item in loomad.Values)
                    {
                        Console.WriteLine(item.Nimi);
                    }
                }
            }
            List<Loom> looms= new List<Loom>();
            looms.Add(loom1);
            looms.Add(loom2);
            looms.Add(new Loom() { Nimi = "Rudik" });
            foreach (Loom item in looms) 
            {
               Console.WriteLine(item.Nimi);
            }



            //double arv1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Tehe: ");
            //string tehe = Console.ReadLine();
            //Console.WriteLine("Sisesta arv2: ");
            //double arv2 = Convert.ToDouble(Console.ReadLine());
            //double vastus = Alamprogrammid.Kalkulaator(arv1,tehe,arv2);
            //Console.WriteLine(vastus);

            //double vastus1 = Alamprogrammid.Eval(4.ToString() + '+'.ToString() + 5.ToString());
            //Console.WriteLine(vastus1);

            //Console.WriteLine("Sisesta arv1: ");
            //string arv1=Console.ReadLine();
            //Console.WriteLine("Tehe: ");
            //string tehe=Console.ReadLine();
            //Console.WriteLine("Sisesta arv2: ");
            //string arv2=Console.ReadLine();

            //vastus1 = Alamprogrammid.Eval(arv1+tehe+arv2);
            //Console.WriteLine("{0}{1}{2}={3}",arv1,tehe,arv2,vastus1);


        }

    }
}
