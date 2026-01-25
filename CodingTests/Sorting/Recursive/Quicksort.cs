namespace CodingTests.Sorting.Recursive;

public class Quicksort
{
    public static List<int> Sort(List<int> numbers)
    {
        // Base case.
        if (numbers.Count <= 1) return numbers;

        var pivot = numbers[0];
        var smallers = new List<int>();
        var largers = new List<int>();

        for (var i = 1; i < numbers.Count; i++)
        {
            if(numbers[i] < pivot) smallers.Add(numbers[i]);
            else if(numbers[i] > pivot) largers.Add(numbers[i]);
        }
        
        var result = new List<int>();
        result.AddRange(Sort(smallers));
        result.Add(pivot);
        result.AddRange(Sort(largers));
        
        return result;
    }
}