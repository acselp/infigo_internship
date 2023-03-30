namespace PassingCars;

public static class PassingCarsClass
{
    public static SolutionClass SolutionInstance = new SolutionClass();
    public static int[] A = { 0, 1, 1, 0, 1, 1, 1, 0, 1 };
    
    public static void Main(String[] args)
    {
        Console.Write(SolutionInstance.Solution(A));
    }
}