/* Day 1 Challenge
 * Given a non-empty array of integers, every element appears twice except for one. Find that single one.
Note:

Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

Example 1:

Input: [2,2,1]
Output: 1

Example 2:

Input: [4,1,2,1,2]
Output: 4


 * */

using System;
using System.Collections.Generic;
using ThirtyDays;
using static System.Console;

namespace ThrityDays
{
    class Day1
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            Day1 p = new Day1();
            int[] n = new int[] { 4, 1, 2, 1, 2 };

            //Day 1
            // WriteLine (p.SingleNumber(n));
            //Day2
            //WriteLine(p.IsHappy(2)); 

            //Day4 d4 = new Day4();
            //Day4 d4 = new Day4(new int[] { 0, 0, 1 });
            //d4.PrintNums();
            //d4.MoveZeroes(d4.Nums);
            //d4.PrintNums();

            //Day5 d5 = new Day5();
            //WriteLine(d5.MaxProfit(d5.Prices));

            Day6 d6 = new Day6();
            d6.GroupAnagrams(d6._strs);
            ReadLine();
        }

        public int SingleNumber(int[] nums)
        {
            int retval = 0;
            // WriteLine(nums.Length);
            Dictionary<int, int> openWith = new Dictionary<int, int>();

            for(int i=0; i<nums.Length; i++)
            {
                if (!openWith.ContainsKey(nums[i]))
                {
                    openWith.Add(nums[i], 1);
                }
                else
                {
                    openWith[nums[i]]++;
                }
            }

            foreach (KeyValuePair<int, int> item in openWith)
            {
                if (item.Value == 1) return item.Key;
            }

            return retval;
        }

        public bool IsHappy(int n)
        {
            bool retval = false;

            try
            {
                if (n == 1) { retval = true; return retval; }
                if (n == 2 || n == 3) { return false; }

                int newN = 0;

                for (int i = 10, j = 0; j < 1; i = i * 10)
                {
                    if (n / i == 0 && j == 0) { newN = newN + (int)Math.Pow((n / (i / 10)), 2); break; }
                    newN = newN + (int)Math.Pow((n % i), 2);
                }

                return IsHappy(newN);
            }
            catch(StackOverflowException e) { return false; }

            //return retval;
        }
    }
}
