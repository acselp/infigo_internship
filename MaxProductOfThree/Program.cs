namespace MaxProductOfThree;

public static class MaxProductOfThree
{
    public static MaxProductOfThreeSolution SolutionInstance = new();
    public static int[] ArrayWithTheElements = { -3, 1, 2, -2, 5, 6 };

    
    public static void Main(String[] args)
    {
        var maxProductOfThreeElems = SolutionInstance.Solution(ArrayWithTheElements);
        
        Console.Write(maxProductOfThreeElems);
    }
}