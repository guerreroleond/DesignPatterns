using System.Globalization;

namespace CodingTests.Recursive;

public class RecCounter
{
    public static int CountItems(List<int> numbers)
    {
        // Base case.
        if(numbers.Count == 0) return 0;

        var rest = new List<int>(numbers);
        rest.RemoveAt(0);
        // Recursive case.
        return 1 + CountItems(rest);
    }

    public static int Max(List<int> numbers, int initMax = 0)
    {
        if(numbers.Count == 1) return initMax;

        var current = numbers[0];
        var next = numbers[1];

        var currentMax = (current > next) 
            ? current : next;

        var max = (initMax > currentMax)
            ? initMax : currentMax;

        var rest = new List<int>(numbers);
        rest.RemoveAt(0);

        return Max(rest, max);
    }
}
