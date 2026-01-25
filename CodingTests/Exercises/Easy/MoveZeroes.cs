namespace CodingTests.Exercises.Easy;

public class MoveZeroes
{
    public static int[] Move2(int[] nums)
    {
        int lastZeroIndex = 0;
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                var temp = nums[i];
                nums[i] = nums[lastZeroIndex];
                nums[lastZeroIndex] = temp;
                lastZeroIndex = i;
            }
        }
        return nums;
    }
    
    /// <summary>
    /// Given an array of ints 'nums' move all the 0s to the end of it
    /// while maintaining the relative order of all non-zero elements.
    /// NOTE: You must do it in place without making a copy of the array.
    /// </summary>
    /// <param name="nums">Arrays of nums to be sorted.</param>
    /// <returns>The sorted array with all the zeros at the end.</returns>
    public static int[] Move(int[] nums)
    {
        var left = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            // We use the right cursor to find non-zero elements.
            // and left element to update its position.
            if (nums[right] != 0)
            {
                var temp = nums[right];
                nums[right] = nums[left];
                nums[left] = temp;
                left++;
            }
        }
        return nums;
    }
}