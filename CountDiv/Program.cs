namespace CountDiv;

public static class CountDivClass
{
    private static SolutionClass s_sol = new SolutionClass();
    
    public static void Main(String[] args)
    {
        Console.WriteLine(s_sol.Solution(6, 11, 2));
    }
}