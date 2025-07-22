using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_._01_Arrays
{
    public class TwoSumLC
    {
        public static int[] TwoSum()
        {

            int[] nums = { 2, 11, 7, 15 };
            int target = 9;

            Dictionary<int,int> numIndices = new Dictionary<int,int>();

            for(int i = 0; i < nums.Length; i++)
            {
                int complement=target-nums[i];
                if (numIndices.ContainsKey(complement))
                {
                    return new int[] { numIndices[complement],i };
                }

                if (!numIndices.ContainsKey(nums[i]))
                {
                    numIndices.Add(nums[i],i);
                }
            }


            return new int[] { -1, -1 };
        }
     
    }
}
