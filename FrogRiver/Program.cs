namespace FrogRiver;

public static class FrogRiverClass
{
    private static SolutionClass s_sol = new SolutionClass();
    private static int[] s_arr = { 1, 3, 1, 4, 2, 3, 5, 4 };
    
    public static void Main(String[] args)
    {
        Console.WriteLine(s_sol.Solution(5, s_arr));
    }
}