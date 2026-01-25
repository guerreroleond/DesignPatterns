using System;

namespace CodingTests.Algorithms;

public class BinarySearch
{
    public static void FindFirstAndLast(
        List<int> numbers, int wantedNumber, List<int> result, int discarded)
    {
        Console.WriteLine("");
        Console.WriteLine($"Numbers:");
        var halfNumbers = new List<int>();
        foreach(var num in numbers)
        {
            Console.WriteLine();
            Console.Write($" {num} ");
        }

        Console.WriteLine();
        int middleIndex = numbers.Count / 2;
        var middleNumber = numbers[middleIndex];
        Console.WriteLine($"middle index: {middleIndex}");
        Console.WriteLine($"middle number: {middleNumber}");
        if(middleNumber == wantedNumber)
        {// element found.
            result.Add(discarded + middleIndex);
            // Check if second apparence is in prev or next.
            if(middleIndex > 0 
            && wantedNumber == numbers[middleIndex - 1])
            {
                result.Add(discarded + middleIndex - 1);
                return;
            }
            else if(middleIndex < numbers.Count - 2 
            && wantedNumber == numbers[middleIndex + 1])
            {
                result.Add(middleIndex + 1);
                return;
            }
        }
        else if(wantedNumber < middleNumber)
        {// first half
            Console.WriteLine("First half");
            halfNumbers = numbers.GetRange(0, middleIndex);            
        }
        else
        {// second half.
            Console.WriteLine("Second half");
            halfNumbers = numbers.GetRange(middleIndex, middleIndex + 1);
            discarded+= numbers.Count - halfNumbers.Count;
        }
        FindFirstAndLast(halfNumbers, wantedNumber, result, discarded);
    }

    public static int SearchNumberAlt(List<int> numbers, int wanted)
    {
        var low = 0;
        var high = numbers.Count - 1;

        while(low <= high)
        {
            var mid = (low + high) / 2;
            var guess = numbers[mid];
            Console.WriteLine($"mid {mid}");
            Console.WriteLine($"high {high}");
            Console.WriteLine($"low {low}");
            if(guess == wanted)
            {
                 Console.WriteLine($"found index: {mid}");
                 return mid;
            }  
            else if(guess > wanted)
            {
                high = mid - 1;
                Console.WriteLine($"new high {high}");
            }
            else
            {
                low = mid + 1;
                Console.WriteLine($"new low {low}");
            }
        }
        return -1;
    }

    public static int SearchNumber(List<int> numbers, int wantedNumber)
    {
        Console.WriteLine("");
        Console.WriteLine($"Numbers:");
        Console.WriteLine("");
        foreach(var num in numbers)
        {
            Console.WriteLine();
            Console.Write($" {num} ");
        }

        Console.WriteLine();
        int result;
        int middleIndex = numbers.Count / 2;
        var middleNumber = numbers[middleIndex];
        Console.WriteLine($"middle index: {middleIndex}");
        Console.WriteLine($"middle number: {middleNumber}");
        if(middleNumber == wantedNumber) return middleNumber;
        else if(wantedNumber < middleNumber)
        {// first half
            Console.WriteLine("First half");
            var halfNumbers = numbers.GetRange(0, middleIndex);
            result = SearchNumber(halfNumbers, wantedNumber);
        }
        else
        {// second half
            Console.WriteLine("Second half");
            var halfNumbers = numbers.GetRange(middleIndex, middleIndex + 1);
            result = SearchNumber(halfNumbers, wantedNumber);
        }

        return result;
    }
}
