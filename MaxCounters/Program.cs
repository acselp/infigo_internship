namespace MaxCounters;

public static class MaxCountersClass
{
    private static SolutionClass s_sol = new SolutionClass();
    private static int[] s_arr = { 3, 4, 4, 6, 1, 4, 4 };
    private static int s_n = 5;
    
    public static void Main(String[] args)
    {
        int[] _a = s_sol.Solution(s_n, s_arr);
        
        for (int i = 0; i < s_n; i++)
        {
            Console.Write(" " + _a[i]);
        }
    }
}