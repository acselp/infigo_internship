namespace MaxCounters;

public static class Day1
{

    public static Solution s = new Solution();
    public static int[] A = { 3, 4, 4, 6, 1, 4, 4 };
    public static int N = 5;
    
    public static void Main(String[] args)
    {

        int[] a = s.solution(N, A);
        
        for (int i = 0; i < N; i++)
        {
            Console.Write(" " + a[i]);
        }
        
    }
}