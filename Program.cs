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
            IQ_344 test = new IQ_344();


            var result = test.ReverseString("abcef");

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
