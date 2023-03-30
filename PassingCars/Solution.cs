namespace PassingCars;

public class SolutionClass
{
    public int Solution(int[] A)
    {
        var n = A.Length;
        var passedCars = 0;
        
        for (int i = 0; i < n; i++)
        {
            if (A[i] == 0)
            {
                for (int j = i; j < n; j++)
                {
                    if (A[j] == 1)
                    {
                        passedCars++;
                    }
                }
            }
        }

        return passedCars;
    }
}