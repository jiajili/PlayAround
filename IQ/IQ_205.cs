using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_205
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s == null || t == null) return false;
            if (s.Length != t.Length) return false;

            Dictionary<char, char> dict = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                char c_s = s[i];
                char c_t = t[i];

                if (dict.ContainsKey(c_s))
                {
                    if (dict[c_s] != c_t)
                    {
                        return false;
                    }
                }
                else
                {
                    if (dict.ContainsValue(c_t))
                    {
                        return false;
                    }

                    dict.Add(c_s, c_t);
                }
            }

            return true;
        }
    }
}
