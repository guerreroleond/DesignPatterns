using System.Xml.XPath;

namespace CodingTests;

public class Fibonacci
{    
    private readonly int[] _fibNums = 
    //   0  1  2  3  4  5   6  7   8   9   10  11   12   13   14   15   16    17 
        [1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584];

    private List<int> _memo = new();
    
    // Recursive Naive 
    public int Fib(int n)
    {
        var result = -1;

        if(n <= 1) result = 1; //n <= 1 because array is zero based.
        else result = Fib(n -1) + Fib(n -2);

        return result;
    }

    // Memoization
    public int FibM(int n)
    {
        var result = -1;
        var isNInMemo = _memo.IndexOf(n) != -1;

        if(isNInMemo) 
        {
            result = _memo[_memo.IndexOf(n)];
            return result;
        }

        if(n <= 1) result = 1; //n <= 1 because array is zero based.
        else result = Fib(n -1) + Fib(n -2);

        _memo.Add(n);
        return result;        
    }

    public int BottFib(int n)
    {
        var result = -1;

        for(int i = 1; i < n + 1; i++)
        {
            if(i <= 1) result = 1;
            else result = _memo[i - 1] + _memo[i - 2];

            _memo.Add(result);
        }

        return _memo[n];
    }
}
