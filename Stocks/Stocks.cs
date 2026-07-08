public class Solution {
    public int MaxProfit(int[] prices) {
        int min = prices[0]; 
        int profit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < min)
            min = prices[i];
            profit = Math.Max(profit, prices[i] - min);

        }
        return profit;        
    }
}