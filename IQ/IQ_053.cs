using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    public class IQ_053
    {
        public int MaxSubArray(int[] nums)
        {
            if(nums == null || nums.Length == 0) return int.MinValue;
            if(nums.Length == 1) return nums[0];

            int max = 0;
            int current = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int tmp = nums[i];
                current += tmp;

                if(current < 0){
                    current = 0;
                }

                max = Math.Max(max, current);
            }

            if (max == 0)
            {
                max = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    max = Math.Max(nums[i], max);
                }
            }

            return max;
        }
    }
}
