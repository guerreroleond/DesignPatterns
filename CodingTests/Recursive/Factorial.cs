namespace CodingTests.Recursive;

public class Factorial
{
    public static int Fact(int number)
    {
        if(number <= 1)
            return 1;
        else
            return number * Fact(number - 1);
    }
}
