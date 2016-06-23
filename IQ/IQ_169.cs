using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_169
    {
        public int MajorityElement(int[] nums)
        {
            int currentValue = nums[0];
            int count = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (currentValue == nums[i])
                {
                    count++;
                }
                else
                {
                    if (count > 1)
                    {
                        count--;
                    }
                    else
                    {
                        count = 1;
                        currentValue = nums[i];
                    }
                }
            }

            return currentValue;
        }
    }
}
