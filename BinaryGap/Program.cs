namespace BinaryGap;

public static class BinaryGapClass
{
    private static SolutionClass s_sol = new SolutionClass();
    public static void Main(String[] args)
    {
        int _value = 100000;
        
        Console.WriteLine(Convert.ToString(_value, 2));
        Console.WriteLine(s_sol.Solution(_value));
    }
}




