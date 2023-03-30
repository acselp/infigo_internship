namespace PassingCars;

public class SolutionClass
{
    public int Solution(int[] A)
    {
        var n = A.Length;
        var passedCars = 0;
        var counter = 0;
        
        for (int i = 0; i < n; i++)
        {
            if (A[i] == 0)
            {
                counter++;
            }
            else
            {
                passedCars += counter;
            }
        }

        if (passedCars > 1000000000)
        {
            return -1;
        }
        
        return passedCars;
    }
}