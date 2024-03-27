using System;
using leetCode;

class Program
{
    static void Main(string[] args)
    {
        //Subarray sbArr = new Subarray();
        //Console.WriteLine("the sub. array product number is : " + sbArr.NumSubarrayProductLessThanK(new int[] { 10, 5, 2, 6 }, 0));
        //Console.WriteLine("the sub. array product number is : " + sbArr.NumSubarrayProductLessThanK(new int[] { 10, 5, 2, 6 }, 100));

        SortByBit sortByBit = new SortByBit();
        int[] sortedArray = sortByBit.SortByBitsFunc(new int[] { 1, 4, 6, 9 });

        Console.WriteLine("The sorted Array by bit: " + string.Join(", ", sortedArray));




    }

}