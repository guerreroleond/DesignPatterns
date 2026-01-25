namespace CodingTests.Exercises.Easy;

public class BestTimeProfit
{
    public static int CalculateBestProfit(int[] prices)
    {
        int? minBuy = null;
        int? maxSell = null;
        int? minBuyIndex = 0;
        int? maxSellIndex = 0;
        var maxProfit = 0;
        
        for (var i = 0; i < prices.Length; i++)
        {
           var current = prices[i]; // 7 | 1
           var next = prices[i + 1]; // 1 | 5

           if (current > next) // No profit
           {// false | true
               if(minBuy == null)
                    minBuy = next;
           }
           else // Profit
           {
               var profit = next - current;
               if(maxSell == null 
               || profit < maxSell)
                   maxSell = profit;
               
               if (profit > maxProfit) maxProfit = profit;
           }
        }

        return maxProfit;
    }

    public static int MaxProfit(int[] prices)
    {
        var minPrice = int.MaxValue;
        var maxProfit = 0;

        foreach (var price in prices)
        {
            if(price < minPrice)
                minPrice = price;
            else
            {
                var profit = price - minPrice;
                maxProfit = Math.Max(maxProfit, profit);
            }
        }
        
        return maxProfit;
    }
    
    public static int CalcBestProfit(int[] prices)
    {
        var left = 0;
        int? minBuy =  null;
        int? maxSell = null;
        var stockMap = new Dictionary<string, int>();
        var maxProfit = 0;

        for (var day = 0; day < prices.Length; day++)
        {
            // Calculate if today´s price is lesser than minBuy.
            if (minBuy == null
            || prices[day] < minBuy)
            {
                minBuy = prices[day];
                stockMap["minBuy"] = day;
            }
            // Calculate if today's price is greater than maxSell.
            if (maxSell == null
            || prices[day] > maxSell)
            {
                maxSell = prices[day];
                stockMap["maxSell"] = day;
            }
            // Is minBuy after maxSell?
            if (stockMap["minBuy"] >= stockMap["maxSell"])
            {// Move window.
                left = day;
                maxSell = prices[day];
                stockMap["maxSell"] = day;
            }
            // Calculate maxProfit.
            if (minBuy is not null
            && maxSell is not null)
            {
                var profit = (int)maxSell - (int)minBuy;
                maxProfit = int.Max(profit, maxProfit);
            }
        }
        return maxProfit;
    }
}