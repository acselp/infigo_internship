

namespace BinaryGap;

public static class Day1
{

    private static Solution s = new Solution();

    public static void Main(String[] args)
    {
        int value = 100000;
        
        Console.WriteLine(Convert.ToString(value, 2));
        Console.WriteLine(s.solution(value));
    }
}




