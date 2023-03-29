namespace PermCheck;

public static class PermCheckClass
{
    public static SolutionClass _sol = new SolutionClass();
    private static int[] _arr = { 1, 3, 4 };
    
    public static void Main(String[] args)
    {
        Console.WriteLine(_sol.Solution(_arr));
    }
}