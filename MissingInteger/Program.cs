namespace MissingIntegers;

public static class MissingIntegersClass
{
    public static SolutionClass Sol = new SolutionClass();
    public static int[] Arr = { -1 };

    public static void Main(String[] args)
    {
        var a = Sol.Solution(Arr);
        
        Console.Write(a);
    }
}