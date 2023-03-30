namespace MissingIntegers;

public static class MissingIntegersMain
{
    public static MissingInteger Sol = new MissingInteger();
    //This array will be checked for missing elements (in this example the missing element is 5)
    public static int[] ArrayWithTheElements = { 1, 3, 6, 4, 1, 2 };

    public static void Main(String[] args)
    {
        var array = Sol.MissingIntegerSolution(ArrayWithTheElements);
        
        Console.Write(array);
    }
}