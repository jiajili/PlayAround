using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_151
    {
        public string ReverseWords(string s)
        {
            if (s == null || s.Length <= 0) return s;

            var splitedStr = s.Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = splitedStr.Length - 1; i >= 0; i--)
            {
                if (!splitedStr[i].Equals(""))
                {
                    sb.Append(splitedStr[i]).Append(" ");
                }

            }

            return sb.ToString().Trim();
        }

        public string ReverseWords2(string s)
        {
            if (s == null || s.Length <= 0) return s;

            char[] c_arr = s.ToCharArray();
            Reverse(c_arr, 0, c_arr.Length);

            int left = 0;
            int right = 0;

            while (right < s.Length)
            {
                if (c_arr[right] == ' ')
                {
                    Reverse(c_arr, left, right);

                    left = right + 1;
                }

                right++;
            }

            var ret = new string(c_arr);
            return ret.Trim();
        }


        private void Reverse(char[] c_arr, int left, int right)
        {
            int mid = (left + right) / 2;
            for (int i = left; i < mid; i++)
            {
                char tmp = c_arr[i];
                c_arr[i] = c_arr[right + left - i - 1];
                c_arr[right + left - i - 1] = tmp;
            }               
        }
    }
}
