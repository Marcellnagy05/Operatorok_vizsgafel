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
            

        }
    }
}
