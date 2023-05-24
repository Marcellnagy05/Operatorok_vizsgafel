using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Kifejezesek
    {
        int firstNum;
        int secondNum;
        string operStr;

        public Kifejezesek(string csvSor)
        {
            var mezok = csvSor.Split(' ');
            this.firstNum = Convert.ToInt32(mezok[0]);
            this.secondNum = Convert.ToInt32(mezok[2]);
            this.operStr = mezok[1];
        }
        
        public Kifejezesek(int firstNum, int secondNum, string operStr)
        {
            this.firstNum = firstNum;
            this.secondNum = secondNum;
            this.operStr = operStr;
        }

        public int FirstNum { get => firstNum; set => firstNum = value; }
        public int SecondNum { get => secondNum; set => secondNum = value; }
        public string OperStr { get => operStr; set => operStr = value; }
    }
}
