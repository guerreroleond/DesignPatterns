namespace CodingTests.Exercises.Easy;

// Description:
// Given two strings s and t, return true if t is an anagram of s
// otherwise return false.
// Example
// s = "anagram", t = "nagaram" → true
// s = "rat", t = "car" → false

public class ValidAnagram
{
    public static bool IsAnagramOptimalLowercase(string s, string t)
    {
        if (s.Length != t.Length) return false;

        int[] freq = new int[26];

        foreach (char c in s)
            freq[c - 'a']++;

        foreach (char c in t)
        {
            if (--freq[c - 'a'] < 0)
                return false;
        }

        return true;
    }

    
    public static bool IsAnagramOptimal(string s, string t)
    {
        // The length of both strings must be the same.
        if(s.Length != t.Length) return false;
        
        // Need a dictionary to store the char counts.
        var charCounts = new Dictionary<char, int>();
        // Iterate the first string and store the char counts.
        foreach (var c in s)
        {
            if (charCounts.ContainsKey(c))
                charCounts[c] ++;
            else
                charCounts[c] = 1;
        }
        // Iterate the second string and reduce the char counts.
        foreach (var c in t)
        {
            if (charCounts.TryGetValue(c, out var count))
            {
                if (count == 1) 
                    charCounts.Remove(c);
                else
                    charCounts[c]--;
            }
            else
            {
                return false;
            }
        }

        // At the end charCounts must be empty.
        return charCounts.Count == 0;
    }
    
    public static bool IsAnagram(string s, string t)
    {
        // The length of both strings must be the same.
        if(s.Length != t.Length) return false;
        
        // We need a dictionary to store the chars.
        var chars = new List<char>();
        // Iterate first string and add the chars to a dictionary.
        for (var i = 0; i < s.Length; i++)
        {
            chars.Add(s[i]);
        }
        // Iterate second string and remove chars from the dictionary.
        for (var i = 0; i < t.Length; i++)
        {
            var c = chars.FirstOrDefault(x => x == t[i]);
            chars.Remove(c);
        }
        // If is anagram, chars must be empty.
        return chars.Count == 0;
    }
}