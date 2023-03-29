namespace CyclicRotation;

public static class CyclicRotationClass
{
    private static int[] _arr = { 3, 8, 9, 7, 6 };
    private static SolutionClass _sol = new SolutionClass();

    public static void Main(String[] args)
    {
        var k = 3;
        var l = _sol.Solution(_arr, k);

        for (var i = 0; i < l.Length; i++)
        {
            Console.Write(l[i] + " ");
        }
    }
}