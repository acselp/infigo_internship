﻿namespace BinaryGap;

public static class BinaryGapClass
{
    private static SolutionClass _sol = new SolutionClass();
    
    public static void Main(String[] args)
    {
        int value = 100000;
        
        Console.WriteLine(Convert.ToString(value, 2));
        Console.WriteLine(_sol.Solution(value));
    }
}