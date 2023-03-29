namespace MissingIntegers;

public class Solution
{
    public int solution(int[] A)
    {
        int[] temp = new int[A.Length];
        int min_int = Int32.MaxValue;
        
        for (int i = 0; i < A.Length; i++)
        {
            temp[i] = i + 1;
        }

        for (int i = 0; i < A.Length; i++)
        {
            if (!A.Contains(temp[i]) && min_int > (i + 1))
            {
                min_int = i + 1;
            }
        }

        if (min_int == Int32.MaxValue)
        {
            min_int = A.Length + 1;
        }

        return min_int;
    }
}