namespace MaxCounters;

public static class MaxCountersClass
{
    private static SolutionClass _sol = new SolutionClass();
    private static int[] _arr = { 3, 4, 4, 6, 1, 4, 4 };
    private static int _n = 5;
    
    public static void Main(String[] args)
    {
        var a = _sol.Solution(_n, _arr);
        
        for (var i = 0; i < _n; i++)
        {
            Console.Write(" " + a[i]);
        }
    }
}