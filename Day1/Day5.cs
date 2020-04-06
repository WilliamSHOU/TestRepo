//https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/

using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ThirtyDays
{
    class Day5
    {
        private int[] _prices;
        public Day5()
        {
            //_prices = new int[] { 7, 1, 5, 3, 6, 4 };
            //_prices = new int[] { 7, 6, 4, 3, 1 };
            //_prices = new int[] { 1, 2, 3, 4, 5 };
            _prices = new int[] { 6, 1, 3, 2, 4, 7 }; //7 
        }

        public Day5(int[] prices)
        {
            this._prices = prices;
        }

        public int MaxProfit(int[] prices)
        {
            int retval = 0, start = -1, end = -1;
            bool canBuy = true;

           for(int i = 0; i< prices.Length-1; i++)
           {
                if (prices[i + 1] > prices[i] && canBuy)
                {
                    start = i;
                    WriteLine("start: " + start);
                    canBuy = false;
                }
                else if (prices[i + 1] <= prices[i] && !canBuy)
                {
                    end = i;
                    WriteLine("End: " + end);
                    canBuy = true;

                    retval += prices[end] - prices[start];
                }
                else { }

                if (i + 1 == prices.Length - 1 && end < start)
                {
                    end = i + 1;
                    WriteLine("End: " + end);
                    retval += prices[end] - prices[start];
                }
            }

            return retval;
        }


        public int[] Prices
        {
            get { return _prices; }
            set { _prices = value; }
        }
    }
}
