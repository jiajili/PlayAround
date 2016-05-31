using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    /// <summary>
    /// https://leetcode.com/problems/sort-colors/
    /// 
    /// Given an array with n objects colored red, white or blue, sort them so that objects of the same color are adjacent, 
    /// with the colors in the order red, white and blue.
    /// Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.
    /// </summary>
    public class IQ_075
    {
        public void SortColors(int[] nums)
        {
            if (nums == null || nums.Length <= 1) return;

            int red=0, white = 0, blue = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    nums[blue] = 2;
                    nums[white] = 1;
                    nums[red] = 0;
                    blue++;
                    white++;
                    red++;
                }
                else if (nums[i] == 1)
                {
                    nums[blue] = 2;
                    nums[white] = 1;
                    blue++;
                    white++;
                }
                else if (nums[i] == 2)
                {
                    nums[blue] = 2;
                    blue++;
                }
            }
            
        }

        public void SortColors2(int[] nums)
        {
            if (nums == null || nums.Length <= 1) return;

            int red = 0, white = 0, blue = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    red++;
                }
                else if (nums[i] == 1)
                {
                    white++;
                }
                else if (nums[i] == 2)
                {
                    blue++;
                }
            }

            int index = 0;

            for (; index< red; index++)
            {
                nums[index] = 0;
            }

            for (; index < white + red; index++)
            {
                nums[index] = 1;
            }

            for (; index < white + red + blue; index++)
            {
                nums[index] = 2;
            }

        }
    }
}
