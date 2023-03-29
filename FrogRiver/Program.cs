namespace FrogRiver;

public static class FrogRiverClass
{
    private static SolutionClass _sol = new SolutionClass();
    private static int[] _arr = { 1, 3, 1, 4, 2, 3, 5, 4 };
    
    public static void Main(String[] args)
    {
        Console.WriteLine(_sol.Solution(5, _arr));
    }
}