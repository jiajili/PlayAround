using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_242
    {
        public bool IsAnagram(string s, string t)
        {
            if (s == null && t == null) return true;
            if((s != null && t == null) || (s == null && t != null)) return false;

            if (s.Length != t.Length) return false;

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach(char c in s){
                if(dict.ContainsKey(c)){
                    dict[c] = 1 + dict[c];
                }else{
                    dict.Add(c,1);
                }
            }

            foreach(char c in t){
                if(dict.ContainsKey(c)){
                    if(dict[c] == 1){
                        dict.Remove(c);
                    }else{
                        dict[c] = dict[c] - 1;
                    }
                }else{
                    return false;
                }
            }

            return dict.Count == 0 ? true : false;
        }
    }
}
