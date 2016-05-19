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
            IQ_283 test = new IQ_283();
            int[] input = {0,1,0,3,12};
            test.MoveZeroes(input);

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }

            Console.ReadKey();
        }
    }
}
