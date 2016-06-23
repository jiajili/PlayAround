using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_165
    {
        public int CompareVersion(string version1, string version2)
        {
            string[] version1Arr = version1.Split('.');
            string[] version2Arr = version2.Split('.');

            int index = 0;

            while (index < version1Arr.Length || index < version2Arr.Length)
            {
                if (index < version1Arr.Length && index < version2Arr.Length)
                {
                    if (int.Parse(version1Arr[index]) > int.Parse(version2Arr[index]))
                    {
                        return 1;
                    }
                    else if (int.Parse(version1Arr[index]) < int.Parse(version2Arr[index]))
                    {
                        return -1;
                    }
                }
                else if (index >= version1Arr.Length)
                {
                    if(int.Parse(version2Arr[index]) > 0){
                        return -1;
                    }
                }else if(index >= version2Arr.Length){
                    if(int.Parse(version1Arr[index]) > 0){
                        return 1;
                    }
                }

                index++;
            }

            return 0;
        }
    }
}
