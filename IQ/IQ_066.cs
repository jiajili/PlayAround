using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_066
    {
        public int[] PlusOne(int[] digits)
        {
            if (null == digits || digits.Length == 0) return null;
            

            bool carry = true;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if(carry){
                    if(digits[i] == 9){
                        digits[i] = 0;
                        carry = true;
                    }else{
                       digits[i] = digits[i] + 1;
                        carry = false;
                    }
                }
            }

            if(carry){
                int[] ret = new int[digits.Length + 1];
                ret[0] = 1;
                for (int i = 0; i < digits.Length; i++)
                {
                    ret[i + 1] = digits[i];
                }

                return ret;

            }else{
                return digits;
            }

        }
    }
}
