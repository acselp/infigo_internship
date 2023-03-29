namespace PermMissingElem;

public static class PermMissingElemClass
{
    private static SolutionClass _sol = new SolutionClass();
    private static int[] _arr = { 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 15, 14, 16, 17, 18, 19, 6 };
    
    public static void Main(String[] args)
    {
        Console.WriteLine(_sol.Solution(_arr));
    }
}