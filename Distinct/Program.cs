using System;

namespace Distinct;

public static class DistinctClass
{
    public static SolutionDistinct SolutionInstance = new SolutionDistinct();
    public static int[] Array = { 1, 1, 1, 2, 3, 4, 4, 5 };
    
    public static void Main(String[] args)
    {
        Console.Write(SolutionInstance.Solution(Array));
    }
}