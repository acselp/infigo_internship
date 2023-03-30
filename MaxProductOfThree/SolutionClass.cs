namespace MaxProductOfThree;

public class SolutionClass
{
    public int Solution(int[] a)
    {
        var n = a.Length;

        for (int i = 0; i < 3; i++)
        {
            for (int j = i; j < n - i - 1; j++)
            {
                if (a[i] > a[i + 1])
                {
                    (a[i], a[i + 1]) = (a[i + 1], a[i]);
                }
            }
        }

        return a[n - 1] * a[n - 2] * a[n - 3];
    }
}