namespace CodingTests.Exercises.Easy;

public class ContainsDuplicates
{
    // Contains Duplicate (Easy)
    //
    // Time estimate: 5–8 minutes
    //     Topic: HashSet
    //
    //     Description:
    // Given an integer array nums,
    // return true if any value appears at least twice in the array.
    //      Example:
    // [1,2,3,1] → true
    // [1,2,3,4] → false


    /// <summary>
    /// Steps:
    /// Iterate the array and save the nums in a HashSet
    /// until we try to save a duplicate (The Add method return false)
    /// </summary>
    /// <param name="nums">The numbers array to evaluate.</param>
    /// <returns>A boolean indicating weather if there is a duplicate </returns>
    public static bool CheckOptimal(int[] nums)
    {
        // At least 2 elements to have duplicates.
        if (nums.Length < 2) return false;
        
        var seenNums = new HashSet<int>();

        foreach (var num in nums)
        {
            if(!seenNums.Add(num)) 
                // Already seen (early exit).
                return true;
        }
        return false;
    }
    
    // Steps:
    // Iterate through the array and store the count in a dictionary.
    // Return true if any reaches 2.
    public static bool Check(int[] nums)
    {
        // At least 2 elements to have duplicates.
        if (nums.Length < 2) return false;
        
        // Need a dict to keep the counts.
        var numCounts = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!numCounts.ContainsKey(num))
                numCounts[num] = 1;
            else
                return true;
        }
        
        return false;
    }
}