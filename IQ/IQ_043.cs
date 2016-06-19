using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_043
    {
        public string Multiply(string num1, string num2)
        {
            char[] input = num1.ToCharArray();
            Array.Reverse(input);
            var n1 = new string(input);

            input = num2.ToCharArray();
            Array.Reverse(input);
            var n2 = new string(input);

            int[] d = new int[num1.Length + num2.Length];

            for (int i = 0; i < n1.Length; i++)
            {
                for (int j = 0; j < n2.Length; j++)
                {
                    d[i + j] += (n1[i] - '0') * (n2[j] - '0');
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < d.Length; i++)
            {
                int mod = d[i] % 10;
                int carry = d[i] / 10;

                if (i + 1 < d.Length)
                {
                    d[i + 1] += carry;
                }

                sb.Insert(0, mod);
            }

            while (sb[0] == '0' && sb.Length > 1)
            {
                sb.Remove(0, 1);
            }

            return sb.ToString();
        }
    }
}
