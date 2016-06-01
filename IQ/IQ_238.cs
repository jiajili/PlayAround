using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    /// <summary>
    /// https://leetcode.com/problems/product-of-array-except-self/
    /// 
    /// Product of Array Except Self
    /// Given an array of n integers where n > 1, nums, return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].
    /// Solve it without division and in O(n). 
    /// For example, given [1,2,3,4], return [24,12,8,6].
    /// </summary>
    public class IQ_238
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            if (null == nums) return null;
            int[] ret = new int[nums.Length];

            int left = 1;
            int right = 1;

            int length = nums.Length;
            for (int i = 0; i < length; i++)
            {
                ret[i] = 1;
            }

            for (int i = 0; i < length; i++)
            {
                ret[i] *= left;
                ret[length - 1 - i] *= right;
                left *= nums[i];
                right *= nums[length - i - 1];
            }

            return ret;
        }
    }
}
