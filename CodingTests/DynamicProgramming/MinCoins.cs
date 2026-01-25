namespace CodingTests;

public class MinCoins
{
    private readonly int[] _coins = [1, 4, 5];

    public int? Coins(int m, List<int> coins)
    {
        int? result = null;

        if(m == 0) result = 0;
        else
        {
            foreach(var coin in coins)
            {
                var subproblem = m - coin;
                if(subproblem < 0) continue;

                result = MinIgnore(
                            result, Coins(subproblem, coins) + 1);
            }
        }
        return result;
    }

    private int? MinIgnore(int? a, int? b)
    {
        if (a == null) return b;
        if (b == null) return a;

        return MinIgnore(a, b);
    }
}
