using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_202
    {
        public bool IsHappy(int n)
        {
            HashSet<int> set = new HashSet<int>();

            while (!set.Contains(n))
            {
                set.Add(n);

                n = Sum(GetDigits(n));
                if (n == 1)
                    return true;
            }

            return false;
        }

        public int Sum(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum = sum + i * i;
            }
            return sum;
        }

        private int[] GetDigits(int n)
        {
            String s = n.ToString();
            int[] result = new int[s.Length];
            int i = 0;

            while (n > 0)
            {
                int m = n % 10;
                result[i++] = m;
                n = n / 10;
            }

            return result;
        }
    }
}
