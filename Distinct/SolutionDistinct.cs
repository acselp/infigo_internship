namespace Distinct;

// Counts the number of distinct elements in a array
public class SolutionDistinct
{
    public int Solution(int[] a)
    {
        var temp = new HashSet<int>();
        var nrDistinct = 0;
        
        for (int i = 0; i < A.Length; i++)
        {
            if (!temp.Contains(A[i]))
            {
                temp.Add(A[i]);
                nrDistinct++;
            }
        }

        return nrDistinct;
    }
}