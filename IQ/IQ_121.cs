using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_121
    {
        public int MaxProfit(int[] prices)
        {
            if ((prices == null) || prices.Length < 2) return 0;
            int maxProfit = 0;
            int currentMin = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                maxProfit = Math.Max(maxProfit, prices[i] - currentMin);
                currentMin = Math.Min(prices[i], currentMin);
            }

            return maxProfit;
        }
    }
}
