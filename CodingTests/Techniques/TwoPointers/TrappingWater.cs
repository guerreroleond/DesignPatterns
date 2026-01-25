namespace CodingTests.Techniques.TwoPointers;

public class TrappingWater
{
    public static int Trap(int[] elevations)
    {
        // At least three elevations are needed in order to create a valley to trap the water.
        if (elevations.Length < 3) return 0;
        
        var waterDict = new Dictionary<int, int>();
        int left = 0;
        var right = 0;
        int tempWater = 0;
        int water = 0;

        for (var i = 0; i < elevations.Length; i++)
        {
            if (elevations[i] > 0 && left == 0)
            {
                left = elevations[i];
            }

            if (elevations[i] < left)
            {// We are in an unclosed valley, save the temp water.
                var level = left + 1 - elevations[i];
                //tempWater = left - elevations[i];
                waterDict[level] += left - elevations[i];
            }

            if (elevations[i] >= left
            || i == elevations.Length - 1)
            {
                right = elevations[i];
                var maxHeight = (left > right) ? left : right;
                foreach (var level in waterDict)
                {
                    if (level.Value >= maxHeight)
                    {
                        water += level.Value;
                    }
                }
                waterDict.Clear();
            }
        }
        return water;
    }
}