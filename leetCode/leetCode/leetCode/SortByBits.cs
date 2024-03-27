using System;
namespace leetCode
{
	public class SortByBit
	{
        public int[] SortByBitsFunc(int[] arr)
        {
            Array.Sort(arr, (x, y) =>
                CountBits(x).CompareTo(CountBits(y)) != 0 ? CountBits(x).CompareTo(CountBits(y)) : x.CompareTo(y));
            return arr;
        }

        private int CountBits(int num)
        {
            int count = 0;
            while (num != 0)
            {
                count += num & 1;
                num >>= 1;
            }
            return count;
        }
    }
}

