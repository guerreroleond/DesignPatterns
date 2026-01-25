namespace CodingTests.Recursive;

public class RecSum
{
    public static int Sum(List<int> numbers)
    {
        // Base case.
        if(numbers.Count == 0) return 0;

        var first = numbers[0];
        var rest = new List<int>(numbers);
        rest.RemoveAt(0);
        // Recursive case.
        return first + Sum(rest);
    }
}
