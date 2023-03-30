namespace MissingIntegers;

public class SolutionClass
{
    public int Solution(int[] a)
    {
        var n = a.Length;
        int[] numsPresent = new int[n + 1];

        for (int i = 0; i < n; i++)
            numsPresent[i] = 0;

        for (int i = 0; i < n; i++)
            if(a[i] > 0 && a[i] < n + 1) 
                numsPresent[a[i] - 1] = 1;
        
        for (int i = 0; i <= n + 1; i++)
            if (numsPresent[i] == 0)
                return i + 1;

        return n;
    }
}