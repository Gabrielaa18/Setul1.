using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setul1_ex20_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti f: ");
            int f = int.Parse(Console.ReadLine());
            if (f == 20)
                P20();
            if (f == 21)
                P21();
        }
        private static void P20()
        {
            int m, n;
            Console.WriteLine("Introduceti numaratorul: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numitorul: ");
            n = int.Parse(Console.ReadLine());
            int rest = m % n;
            int cat = m / n;
            List<int> parteZecimala = new List<int>();
            List<int> partePeriodica = new List<int>();
            Dictionary<int, int> resturi = new Dictionary<int, int>();
            int poz = 0;
            while (rest != 0 && !resturi.ContainsKey(rest))
            {
                resturi.Add(rest, poz);
                rest *= 10;
                int auxC = rest / n;
                int auxR = rest % n;
                parteZecimala.Add(auxC);
                rest = auxR;
                poz++;
            }
            if (rest == 0)
            {
                Console.WriteLine($"Fractia {m}/{n} in format zecimal este {cat}");
            }
            else
            {
                int pozPerioada = resturi[rest];
                partePeriodica.AddRange(parteZecimala.GetRange(pozPerioada, parteZecimala.Count - pozPerioada));
                parteZecimala.RemoveRange(pozPerioada, parteZecimala.Count - pozPerioada);
                Console.WriteLine($"Fractia {m}/{n} in format zecimal este: {cat}.{string.Join("", parteZecimala)}{string.Join("", partePeriodica)}");
                Console.ReadLine();
            }


        }
        private static void P21()
        {
            Console.WriteLine("Ganditi-va la un numar intre 1 si 1024");
            int min, max, nr;
            min = 1;
            max = 1024;
            nr = (min + max) / 2;
            string raspuns;
            do
            {
                Console.WriteLine($"Numarul la care va ganditi e mai mare sau egal decat {nr}?");
                raspuns = Console.ReadLine().ToLower();
                if (raspuns == "da")
                {
                    min = nr + 1;
                }
                else
                  if (raspuns == "nu")
                    max = nr - 1;
                else
                    Console.WriteLine("Modificati raspunsul");
                nr = (min + max) / 2;
            } while (min <= max);
            Console.WriteLine($"Numarul la care v-ati gandit este {nr}");
        }
    }
}

