using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_349
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);

            HashSet<int> intersectionSet = new HashSet<int>();

            for(int i=0;i<nums1.Length;i++){
                if (Array.BinarySearch(nums2, nums1[i]) >= 0)
                {
                    intersectionSet.Add(nums1[i]);
                }
            }

            int[] ret = new int[intersectionSet.Count];
            int index = 0;
            foreach (var item in intersectionSet)
            {
                ret[index++] = item;
            }

            return ret;
        }
    }
}
