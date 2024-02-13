public class Solution {
    public int MaxProfit(int[] prices) {
        return CalcualteProfitUsingTwoPoiner(prices);
    }

    private int CalcualteProfitBruteForce(int[] prices){
        int profit = 0;

        for(int i=0; i<prices.Length; i++)
        {
            int buy = prices[i];
            for(int j=i+1; j<prices.Length; j++)
            {
                if(prices[j] - buy > profit)
                {
                    profit = prices[j] - buy;
                }
            }
        }
        return profit;
    }

    private int CalcualteProfit1(int[] prices){
        int profit = 0;
        int minBuy = prices[0];

        for(int i=0; i<prices.Length; i++)
        {
            profit = Math.Max(profit, prices[i] - minBuy);
            minBuy = Math.Min(minBuy, prices[i]);
        }
        return profit;
    }    



    private int CalcualteProfit(int[] prices){
                //buy
        //sell
        //profit = buy-sell
        //if (buy-sell > profit)
        //  profit = buy-sell;
        //At each iteration check buy,sell and profit
        //At each iteration update buy or sell if (buy-sell>profit && sell) profit

        int buy = prices[0];
        int sell = prices[0];
        int buyIndex = 0;
        int sellIndex = 0;
        int profit = buy-sell; 
        for(int i=1; i< prices.Length; i++)
        {
            if(prices[i] < buy)
            {
                buy = prices[i];
                
            }
                

            if(prices[i] > sell && sellIndex < i)
            {
                sell = prices[i];                
                sellIndex = i;
            }

            Console.WriteLine(buy + " : " + sell);
        }

        return sell-buy;
    }

    private int CalcualteProfitUsingTwoPoiner(int[] prices)
    {
      //Start with the left and right pointer
      //set the return profit = 0
      //use Math.Max to find the the profit. RightPointer-LeftPointer
      //compar both the porinters and advace the larger one
      
      //set left = 0;
      //set right = 1
      //if (prices[right]<prices[left])
      //then right++, left++
      //else right++ 

      int left = 0;
      int right = 1;
      int profit = 0;

      while(right < prices.Length)
      {

        if(prices[left] < prices[right])
        {
          int tempProfit = prices[right] - prices[left]; 
          profit = Math.Max(profit, tempProfit);
        }
        else
        {
          left = right;
        }
        right++;
      }
      return profit;      
    }
}
