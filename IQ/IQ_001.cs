using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    /// You may assume that each input would have exactly one solution.
    /// Example:
    // Given nums = [2, 7, 11, 15], target = 9,
    // Because nums[0] + nums[1] = 2 + 7 = 9,
    // return [0, 1].
    // UPDATE (2016/2/13):
    // The return format had been changed to zero-based indices. Please read the above updated description carefully.
    /// </summary>
    public class IQ_001
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] ret = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(nums[0], 0);
            for (int i = 1; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    ret[0] = dict[target - nums[i]];
                    ret[1] = i;

                    return ret;
                }
                else
                {
                    if (dict.ContainsKey(nums[i]) == false)
                        dict.Add(nums[i], i);
                }
            }

            return ret;
        }
    }
}
