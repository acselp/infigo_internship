namespace CyclicRotation;

public static class CyclicRotationClass
{
    private static int[] _arr = { 3, 8, 9, 7, 6 };
    private static SolutionClass _sol = new SolutionClass();

    public static void Main(String[] args)
    {
        int k = 3;
        
        int[] l = _sol.Solution(_arr, k);

        for (int i = 0; i < l.Length; i++)
        {
            Console.Write(l[i] + " ");
        }
    }
}