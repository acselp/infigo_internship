namespace OddOccurrencesInArray;

public static class OddOccurrencesInArray
{
    private static int[] _arr = { 9, 3, 9, 3, 9, 7, 9 };
    private static SolutionClass _sol = new SolutionClass();

    public static void Main(String[] args)
    {
        int l = _sol.Solution(_arr);
        Console.WriteLine(l);
    }
}