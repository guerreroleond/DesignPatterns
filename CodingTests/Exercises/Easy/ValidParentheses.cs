namespace CodingTests.Exercises.Easy;

public class ValidParentheses
{
    public static bool IsValidOptimal(string s)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            // Push opening brackets.
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else
            {
                // If closing but stack empty -> invalid.
                if (stack.Count == 0) return false;
                
                // Take the top char in the stack.
                var top = stack.Pop();
                // Check matching pairs.
                if((c == ')' && top != '(') 
                || (c == ']' && top != '[')
                || (c == '}' && top != '{'))
                    return false;
            }
        }
        // Stack must be empty at the end.
        return stack.Count == 0;
    }
    
    public static bool IsValid(string s)
    {
        var validOpeners = new Dictionary<int, char>
        {
            { 0, '(' },
            { 1, '{' },
            { 2, '[' }
        };
        var validClosers = new Dictionary<int, char>
        {
            { 0, ')' },
            { 1, '}' },
            { 2, ']' },
        };
        
        var inputArray = s.ToCharArray();
        // Check if the count is multiple of 2 so we can compare pairs of chars.
        if(inputArray.Length % 2 != 0 ) throw new ArgumentException(s);
        
        var half = inputArray.Length / 2;
        
        var stack = new Stack<char>(inputArray.Take(half));
        var queue = new Queue<char>(inputArray.Skip(half));

        for (var i = 0; i < half; i += 1)
        {
            var opener = stack.Pop();
            var closer = queue.Dequeue();
            var indexOpener = validOpeners.FirstOrDefault(x => x.Value == opener).Key;
            var indexCloser = validClosers.FirstOrDefault(x => x.Value == closer).Key;
            if(indexOpener != indexCloser) return false;
        }
        
        return true;
    }
}