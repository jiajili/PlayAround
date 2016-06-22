using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_136
    {
        public int SingleNumber(int[] nums)
        {
            int ret = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                ret ^= nums[i];
            }

            return ret;
        }
    }
}
