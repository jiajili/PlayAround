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
            IQ_202 test = new IQ_202();

          
            var result = test.IsHappy(19);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
