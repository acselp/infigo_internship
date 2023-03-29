namespace CyclicRotation;

public static class CyclicRotationClass
{
    private static int[] s_arr = { 3, 8, 9, 7, 6 };
    private static SolutionClass s_sol = new SolutionClass();

    public static void Main(String[] args)
    {
        int _k = 3;
        int[] _l = s_sol.Solution(s_arr, _k);

        for (int i = 0; i < _l.Length; i++)
        {
            Console.Write(_l[i] + " ");
        }
    }
}




