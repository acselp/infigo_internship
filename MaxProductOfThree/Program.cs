namespace MaxProductOfThree;

public static class MaxProductOfThreeClass
{
    public static SolutionClass SolutionInstance = new();
    public static int[] A = { -3, 1, 2, -2, 5, 6 };

    public static void Main(String[] args)
    {
        var a = SolutionInstance.Solution(A);
        
        Console.Write(a);
    }
}