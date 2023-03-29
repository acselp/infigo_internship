namespace MissingIntegers;

public static class Day1
{

    public static Solution s = new Solution();
    public static int[] A = { -1, -2, -3, 2, 3, 5, 6, 7 };
    public static int N = 5;
    
    public static void Main(String[] args)
    {
        int a = s.solution(A);
        
        Console.Write(a);
    }
}