namespace OddOccurrencesInArray;

public static class OddOccurrencesInArray
{
    private static int[] s_arr = { 9, 3, 9, 3, 9, 7, 9 };
    private static SolutionClass s_sol = new SolutionClass();

    public static void Main(String[] args)
    {
        int _l = s_sol.Solution(s_arr);
        Console.WriteLine(_l);
    }
}