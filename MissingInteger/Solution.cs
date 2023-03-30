namespace MissingIntegers;

public class MissingIntegerSolutionClass
{
    public int MissingIntegerSolution(int[] arrayWithTheElements)
    {
        var n = arrayWithTheElements.Length;
        int[] numsPresent = new int[n + 1];

        for (int i = 0; i < n; i++)
            numsPresent[i] = 0;

        for (int i = 0; i < n; i++)
            if(arrayWithTheElements[i] > 0 && arrayWithTheElements[i] < n + 1) 
                numsPresent[arrayWithTheElements[i] - 1] = 1;
        
        for (int i = 0; i <= n + 1; i++)
            if (numsPresent[i] == 0)
                return i + 1;

        return n;
    }
}