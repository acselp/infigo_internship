namespace PermMissingElem;

public static class PermMissingElemClass
{
    private static SolutionClass _sol = new SolutionClass();
    private static int[] _arr = { 3, 1, 2, 4, 3 };
    
    public static void Main(String[] args)
    {
        Console.WriteLine(_sol.Solution(_arr));
    }
}