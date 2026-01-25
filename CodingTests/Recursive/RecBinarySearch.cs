using System;

namespace CodingTests.Recursive;

public class RecBinarySearch
{
    public static int Search(List<int> numbers, int wantedNumber, int currentPosition)
    {
        // Check if numbers are not empty.
        if(numbers.Count == 0) return - 1;

        // Get the middle index/number.
        var middleIndex = numbers.Count / 2;
        var middleNum = numbers[middleIndex];
        // Base case.
        if(middleNum == wantedNumber) return currentPosition += middleIndex;

        var half = new List<int>(numbers);
        if(wantedNumber > middleNum)
        {// Search in second half.
            var halfCount = numbers.Count - (middleIndex + 1);
            half = half.GetRange(middleIndex + 1, halfCount);
            return Search(half, wantedNumber, currentPosition + (numbers.Count - halfCount));
        }
        else
        {// Search in first half.
            half = half.GetRange(0, middleIndex);
            return Search(half, wantedNumber, currentPosition);
        }
    }
}
