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
            IQ_127 test = new IQ_127();
            ISet<string> set = new HashSet<string>();
            set.Add("hot");
            set.Add("dog");

            int k = test.LadderLength("hot", "dog", set);
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
