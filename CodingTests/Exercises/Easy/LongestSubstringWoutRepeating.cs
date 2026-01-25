namespace CodingTests.Exercises.Easy;

public class LongestSubstringWoutRepeating
{
    public static int LongestSubstring(string s)
    {
        if(string.IsNullOrEmpty(s)) return 0;
        
        var maxLength = 0;
        var length = 0;
        var left = 0;
        var charMap = new Dictionary<char, int>();

        for (var right = 0; right < s.Length; right++)
        {
            var c =  s[right];
            // Have we seen this char before?
            if (charMap.TryGetValue(c, out var prev)
            &&  prev >= left) // Is inside the current window?
            {
                // c is inside the current window;
                // Move left one position after its previous index.
                left = prev + 1;
            }
            // Update last seen index.
            charMap[c] = right;
            
            // Window length.
            length = right - left + 1;
            maxLength = Math.Max(maxLength, length);
        }
        
        return maxLength;
    }
}