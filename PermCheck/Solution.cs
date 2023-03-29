namespace PermCheck;

public class SolutionClass
{
    public int Solution(int[] A)
    {
        int[] _temp = new int[A.Length];

        for (int i = 0; i < A.Length; i++)
        {
            _temp[i] = 0;
        }

        try
        {
            for (int i = 0; i < A.Length; i++)
            {
                _temp[A[i] - 1] = A[i];
            }
        }
        catch (IndexOutOfRangeException)
        {
            return 0;
        }
        
        if (_temp.Contains(0))
        {
            return 0;
        }

        return 1;
    }
}