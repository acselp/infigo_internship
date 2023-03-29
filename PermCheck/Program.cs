namespace PermCheck;

public static class PermCheckClass
{
    public static SolutionClass s_sol = new SolutionClass();
    private static int[] s_arr = { 1, 3, 4 };
    
    public static void Main(String[] args)
    {
        Console.WriteLine(s_sol.Solution(s_arr));
    }
}