using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
            Console.WriteLine($"3.feladat: Kifejezések száma maradékos osztással:{kifej.Count(x => x.OperStr == "mod")}");
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
            //5
            string[] array = { "mod", "/", "div", "-", "*", "+" };
            Console.WriteLine("5.feladat: Statisztika: ");
            kifej.Where(x => array.Contains(x.OperStr)).GroupBy(x => x.OperStr).ToList().ForEach(x => Console.WriteLine($"{x.Key} -> {x.Count()} db"));
            //6
            //Console.WriteLine("7.Feladat: Kérek egy kifejezést pl(1 + 1):");
            //string kifejezesek = Console.ReadLine();
            //Console.WriteLine(Beker(kifejezesek));
            //string xd = kifejezesek;
            do
            {
                Console.WriteLine("7.Feladat: Kérek egy kifejezést pl(1 + 1):");
                string Opr = Console.ReadLine();
                Console.WriteLine(Beker(Opr));
            } while (true);
            string Beker(string kifejezes)
            {

                string[] Operandarray = { "mod", "/", "div", "-", "*", "+" };
                string[] kif = kifejezes.Split(' ');

                    if (Operandarray.Contains(kif[1]) && int.Parse(kif[2]) == 0 && kif[1] == "div")
                    {
                        return $"{kif[0]} {kif[1]} {kif[2]} -> {kif[1]} Nullával nem osztunk";
                    }
                    if (Operandarray.Contains(kif[1]))
                    {
                        switch (kif[1])
                        {
                            case "mod":
                            Console.WriteLine($"{kif[0]} % {kif[2]} -> {int.Parse(kif[0]) % int.Parse(kif[2])}");
                                break;
                            case "/":
                                Console.WriteLine($"{kif[0]} / {kif[2]} -> {double.Parse(kif[0]) / double.Parse(kif[2])}");
                                break;
                            case "div":
                            Console.WriteLine($"{kif[0]} div {kif[2]} -> {int.Parse(kif[0]) / int.Parse(kif[2])}");
                                break;
                            case "-":
                            Console.WriteLine($"{kif[0]} - {kif[2]} -> {int.Parse(kif[0]) - int.Parse(kif[2])}"); 
                                break;
                            case "*":
                            Console.WriteLine($"{kif[0]} * {kif[2]} -> {int.Parse(kif[0]) * int.Parse(kif[2])}");
                                break;
                            case "+":
                            Console.WriteLine($"{kif[0]} + {kif[2]} -> {int.Parse(kif[0]) + int.Parse(kif[2])}");
                                break;
                        }
                    }
                    else if (!Operandarray.Contains(kif[1]))
                    {
                        return $"{kif[0]} {kif[1]} {kif[2]} -> {kif[1]}Hibás operátor";
                    }
                    return "";

            }
        }
    }
}
