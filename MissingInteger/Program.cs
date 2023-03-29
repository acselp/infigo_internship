namespace MissingIntegers;

public static class MissingIntegersClass
{
    public static SolutionClass s_sol = new SolutionClass();
    public static int[] s_arr = { -1, -2, -3, 2, 3, 5, 6, 7 };

    public static void Main(String[] args)
    {
        int _a = s_sol.Solution(s_arr);
        
        Console.Write(_a);
    }
}