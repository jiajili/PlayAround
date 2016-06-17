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
            IQ_209 test = new IQ_209();

            int[] arr = {
                1,2,3,4,5
            };
            
            int result = test.MinSubArrayLen(11, arr);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
