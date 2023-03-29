namespace CyclicRotation;

public static class Day1
{
    private static int[] Arr = { 3, 8, 9, 7, 6 };
    private static Solution s = new Solution();

    public static void Main(String[] args)
    {
        int k = 3;
        int[] l = s.solution(Arr, k);

        for (int i = 0; i < l.Length; i++)
        {
            Console.Write(l[i] + " ");
        }
    }
}




