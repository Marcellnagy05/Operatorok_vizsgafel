using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            List<Kifejezesek> kifej =
            File.ReadLines("DataSource\\kifejezesek.txt")
            .Select(x => new Kifejezesek(x))
            .ToList();
            //2
            Console.WriteLine($"2.feladat: Kifejezések száma: {kifej.Count()}");
            //3
            Console.WriteLine($"3.feladat: Kifejezések száma maradékos osztással:{kifej.Count(x=> x.OperStr == "mod")}");
            //4
            var vanE = kifej.Any(x => x.FirstNum % 10 == 0 && x.SecondNum % 10 == 0);
            if (vanE)
            {
                Console.WriteLine("4.feladat: Van ilyen kifejezés");
            }
            else
            {
                Console.WriteLine("4.feladat: Nincs ilyen kifejezés");
            }
        }
    }
}
