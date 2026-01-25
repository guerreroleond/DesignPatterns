using System;

namespace CodingTests.Sorting;

public class SelectionSort
{
    private static int FindSmallest(List<int> numbers)
    {
        var smallest = numbers[0];
        var smallestIndex = 0;

        for(var i = 1; i < numbers.Count - 1; i++)
        {
            if(numbers[i] < smallest)
            {
                smallest = numbers[i];
                smallestIndex = i;
            }
        }

        return smallestIndex;
    }

    public static List<int> Sort(List<int> unorderedList)
    {
        var orderedList = new List<int>();
        var tempList = new List<int>(unorderedList);

        for(var i = 0; i < unorderedList.Count; i++)
        {
            var smallestIndex = FindSmallest(tempList);
            // Add smallest to the ordered list.
            orderedList.Add(tempList[smallestIndex]);
            // Remove smallest from source.
            tempList.RemoveAt(smallestIndex);
        }

        return orderedList;
    }
}
