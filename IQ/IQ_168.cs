using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_168
    {
        public string ConvertToTitle(int n)
        {
            if (n <= 0) return "";

            StringBuilder sb = new StringBuilder();

            while (n!=0)
            {
                n--;                
                sb.Append(Convert.ToChar((n % 26) + 'A'));
                n /= 26;
            }

            var temp = sb.ToString().ToCharArray();
            Array.Reverse(temp);
            return new string(temp);
        }
    }
}
