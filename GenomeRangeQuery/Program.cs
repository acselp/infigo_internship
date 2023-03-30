namespace MissingIntegers;

public static class MissingIntegersClass
{
    public static SolutionClass SolutionInstance = new SolutionClass();
    public static string Genome = "CAGCCTA";
    public static int[] P = { 2, 5, 0 };
    public static int[] Q = { 4, 5, 6 };


    public static void Main(String[] args)
    {
        var a = SolutionInstance.Solution(Genome, P, Q);

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }
    }
}