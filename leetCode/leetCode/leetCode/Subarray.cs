using System;
namespace leetCode
{
	public class Subarray
	{
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {

            int count = 0;
            int product = 1;
            int j = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                product *= nums[i];

                while (j <= i && product >= k)
                {
                    product /= nums[j++];
                }

                count += i - j + 1;
            }

            return count;
        }



    }
}

