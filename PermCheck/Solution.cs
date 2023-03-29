namespace PermCheck;

public class Solution
{
    public int solution(int[] A)
    {
        int[] temp = new int[A.Length];

        for (int i = 0; i < A.Length; i++)
        {
            temp[i] = 0;
        }

        try
        {
            for (int i = 0; i < A.Length; i++)
            {
                temp[A[i] - 1] = A[i];
            }
        }
        catch (IndexOutOfRangeException)
        {
            return 0;
        }
        

        if (temp.Contains(0))
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
}