using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    /// <summary>
    /// https://leetcode.com/problems/move-zeroes/
    /// 
    /// Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of 
    /// the non-zero elements.
    /// For example, given nums = [0, 1, 0, 3, 12], after calling your function, nums should be [1, 3, 12, 0, 0].
    /// Note:
    /// You must do this in-place without making a copy of the array.
    /// Minimize the total number of operations.
    /// </summary>
    public class IQ_283
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums == null || nums.Length <= 1) return;

            int currentIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[currentIndex++] = nums[i];
                }
            }

            for (int i = currentIndex; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
