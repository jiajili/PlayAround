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
            IQ_136 test = new IQ_136();
            int[] arr = { 1, 1, 2, 2, 3 };
           var result =  test.SingleNumber(arr);


            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
