namespace MissingIntegers;

public class SolutionClass
{
    public int Solution(int[] A)
    {
        var temp = new int[A.Length];
        var min_int = Int32.MaxValue;
        
        for (var i = 0; i < A.Length; i++)
        {
            temp[i] = i + 1;
        }

        for (var i = 0; i < A.Length; i++)
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