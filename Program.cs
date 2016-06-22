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
            IQ_067 test = new IQ_067();

           var result =  test.AddBinary("1010", "1011");


            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
