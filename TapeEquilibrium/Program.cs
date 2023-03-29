namespace PermMissingElem;

public static class PermMissingElemClass
{
    private static SolutionClass s_sol = new SolutionClass();
    private static int[] s_arr = { 3, 1, 2, 4, 3 };
    
    public static void Main(String[] args)
    {
        Console.WriteLine(s_sol.Solution(s_arr));
    }
}