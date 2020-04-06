using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ThirtyDays
{
    public class Day4
    {
        private int[] _nums;

        public Day4()
        {
            _nums = new int[] {0,1,0,3,12};
        }

        public Day4(int[] nums)
        {
            this.Nums = nums;
        }

        public void MoveZeroes(int[] nums)
        {//{0,1,0,3,12}
            //[0,0,1]
            int end = nums.Length;
            for (int i=0; i< end; )
            {
                if (nums[i] == 0)
                {
                    for(int j=i+1; j< end; j++)
                    {
                        nums[j-1] = nums[j];
                        nums[j] = 0;
                    }
                    end--;
                }

                if (nums[i] != 0) i++;
            }
        }

        public void PrintNums()
        {
            WriteLine("Printing Array Nums");
            foreach (int i in _nums)
            {
                Write("{0},", i); 
            }
            Write("\n");
        }

        public int[] Nums
        {
            get { return _nums; }
            set { _nums = value; }
        }
    }
}

