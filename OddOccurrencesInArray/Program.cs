namespace OddOccurrencesInArray;

public static class Day1
{
    private static int[] Arr = { 9, 3, 9, 3, 9, 7, 9 };
    private static Solution s = new Solution();

    public static void Main(String[] args)
    {
        int l = s.solution(Arr);
        
        Console.WriteLine(l);
    }
}