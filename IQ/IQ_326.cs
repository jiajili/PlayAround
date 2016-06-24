using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_326
    {
        public bool IsPowerOfThree(int n)
        {
            if (n == 0) return false;
            return n == Math.Pow(3, Math.Round(Math.Log(n) / Math.Log(3)));
        }

        public bool IsPowerOfThree2(int n)
        {
            if (n == 0) return false;
            if (n == 1) return true;
            if (n > 1)
            {
                return n % 3 == 0 && IsPowerOfThree2(n / 3);
            }
            else
                return false;

        }
    }
}
