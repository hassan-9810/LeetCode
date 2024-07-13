public class Solution {
    public int MaxProfit(int[] prices) {
    int maxProfit = 0;
    int minPrice = int.MaxValue;

    for (int i = 0; i < prices.Length; i++)
    {
        minPrice = Math.Min(minPrice, prices[i]);
        maxProfit = Math.Max(maxProfit, prices[i] - minPrice); 
    }

    return maxProfit;
    }
}