using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    public class IQ_209
    {
        public int MinSubArrayLen(int s, int[] nums)
        {
            int min = int.MaxValue;
            int currentSum = 0;
            int begin = 0;
            int end = 0;
            bool exists = false;

            while (end <= nums.Length)
            {                
                if (currentSum >= s)
                {
                    exists = true;
                    if (begin == end - 1) return 1;

                    min = Math.Min(end - begin, min);
                    currentSum -= nums[begin++];
                }
                else
                {
                    if (end == nums.Length) break;

                    currentSum += nums[end++];
                }               
            }

            if (exists)
            {
                return min;
            }
            else
            {
                return 0;
            }
        }
    }
}
