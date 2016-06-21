using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_015
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums == null || nums.Length <= 2) return result;

            Array.Sort(nums);

            for (var i = 0; i < nums.Length - 2; i++)
            {
                var a = nums[i];
                var j = i + 1;
                var k = nums.Length - 1;

                while (j < k)
                {
                    var b = nums[j];
                    var c = nums[k];
                    if (a + b + c == 0)
                    {
                        if (result.Count == 0)
                        {
                            IList<int> tempList = new List<int> { a, b, c };
                            result.Add(tempList);
                        }
                        else
                        {
                            bool containDuplicated = false;
                            for (int m = 0; m < result.Count; m++)
                            {
                                var lastList = result[m];
                                if (lastList[0] == a && lastList[1] == b && lastList[2] == c)
                                {
                                    containDuplicated = true;
                                    break;
                                }
                            }

                            if (containDuplicated == false)
                            {
                                IList<int> tempList = new List<int> { a, b, c };
                                result.Add(tempList);
                            }
                        }

                        j++;
                        k--;
                    }
                    else if (a + b + c > 0)
                    {
                        k--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            return result;
        }
    }
}
