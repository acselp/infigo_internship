namespace MissingIntegers;

public static class MissingIntegersClass
{
    public static SolutionClass _sol = new SolutionClass();
    public static int[] _arr = { -1, -2, -3, 2, 3, 5, 6, 7 };

    public static void Main(String[] args)
    {
        var a = _sol.Solution(_arr);
        
        Console.Write(a);
    }
}