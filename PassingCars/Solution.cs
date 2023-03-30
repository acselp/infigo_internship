namespace PassingCars;

public class PassingCarsSolutionClass
{
    public int Solution(int[] a)
    {
        var n = a.Length;
        var passedCars = 0;
        var counter = 0;
        const int maxPassedCars = 1000000000;
        
        for (int i = 0; i < n; i++)
        {
            if (a[i] == 0)
            {
                counter++;
            }
            else
            {
                passedCars += counter;
            }
        }

        if (passedCars > maxPassedCars || passedCars < 0)
        {
            return -1;
        }
        
        return passedCars;
    }
}