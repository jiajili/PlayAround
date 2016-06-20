using PlayAround.IQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround
{
    class Program
    {
        static void Main(string[] args)
        {
            IQ_211 test = new IQ_211();

            test.AddWord("aa");
            test.AddWord("ab");
            test.AddWord("ca");
            test.AddWord("da");
            test.AddWord("ef");
            test.AddWord("lijiaji");


            Console.WriteLine(test.Search("li.ia.i"));
            Console.ReadKey();
        }
    }
}
