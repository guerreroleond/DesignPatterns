namespace CodingTests.Exercises.Easy;

public class MaxSumOfSubarray
{
    public static int MaxSum(int[] nums, int size)
    {
        var sum = 0;

        // Get the first window sum. 
        for (var i = 0; i < size; i++)
        {
            sum += nums[i];
        }

        var maxSum = sum;
        // Slide the window to get the max sum.
        for (var i = size; i < nums.Length; i++)
        {
            sum = sum - nums[i - size] + nums[i];
            maxSum = Math.Max(maxSum, sum);
        }
        
        return maxSum;
    }
}