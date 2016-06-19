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
            IQ_151 test = new IQ_151();


            var result = test.ReverseWords(" ");

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
