public class Solution {
    public int MaxProfit(int[] prices) {
  int profits = 0;
  for(int i = 0; i < (prices.Length - 1); i++) 
  {
   if(prices[i] < prices[i+1])
    {
      profits = profits + (prices[i+1] - prices[i]);
    }
  }
  return profits;
 }
}