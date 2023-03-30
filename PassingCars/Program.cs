namespace PassingCars;

public static class PassingCarsClass
{
    public static PassingCarsSolutionClass SolutionInstance = new();
    public static int[] CarsArray = { 0, 1, 1, 0, 1, 1, 1, 0, 1 };
    
    public static void Main(String[] args)
    {
        Console.Write(SolutionInstance.Solution(CarsArray));
    }
}