namespace CodingTests.Exercises.Easy;

public class TwoSum
{
    /// <summary>
    /// Given an 1-indexed array of integers 'nums'
    /// that is ordered in non-decreasing order,
    /// find two numbers such that they add up to a specific 'target' number.
    /// Return the indices of the two numbers.
    /// Example: nums = [8,2,0,7,3], target = 9
    /// Result: [2,4]
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static int[] Optimal1Indexed(int[] nums, int target)
    {
        // Map for numbers
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            // Calculate the compliment by subtracting from the target.
            var compliment = target - nums[i];
            if (map.ContainsKey(compliment))
            {// Successful case!
                return [map[compliment] + 1, i +1];
            }
            // Store current number and its index.
            if(!map.ContainsKey(compliment))
                map.Add(nums[i], i);
        }
        
        throw new ArgumentException("No two sum solution");
    }
    
    public static int[] Optimal(int[] nums, int target)
    {
        // Map for numbers, index.
        var map = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (map.ContainsKey(complement))
            {// Successful case!
                return new int[] { map[complement], i };
            }
            // Store current number and its index.
            if(!map.ContainsKey(nums[i]))
                map.Add(nums[i], i);
        }
        
        throw new ArgumentException("No two sum solution");
    }
    
    /// <summary>
    /// This is the Brute Force solution.
    /// Checks every possible pair in the array until you find the two numbers
    /// that sum to the target.
    /// </summary>
    /// <param name="numbers">The given array of numbers to search in.</param>
    /// <param name="target">The target number.</param>
    /// <returns>Indexes of two numbers such that they sum up to target.</returns>
    public static List<int>? BruteForce(int[] numbers, int target)
    {
        var dict = new Dictionary<string, int> { { "target", target } };
        var result = new List<int>();
        
        for(var i = 0; i < numbers.Length; i++)
        {
            if (i >= target) continue;
            dict.Add("num1", i);
            for (var j = 0; j < numbers.Length; j++)
            {
                if (j >= target || i == j) continue;
                if (dict["target"] - numbers[dict["num1"]] == numbers[j])
                {
                    // Successful case!
                    dict.Add("num2", j);
                    result.Add(dict["num1"]);
                    result.Add(dict["num2"]);
                    return result;
                }
            }
            dict.Remove("num1");
        }
        
        return null;
    }
}