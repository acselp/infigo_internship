namespace MaxCounters;

public class SolutionClass
{
    public int[] Solution(int N, int[] A)
    {
        var count = new int[N];
        var max_count = 0;
        
        for (var i = 0; i < N; i++)
        {
            count[i] = 0;
        }

        for (var i = 0; i < A.Length; i++)
        {
            if (A[i] > 0 && A[i] <= N)
            {
                count[A[i] - 1]++;

                if (count[A[i] - 1] > max_count)
                {
                    max_count = count[A[i] - 1];
                }
            }
            else if (A[i] == N + 1)
            {
                for (var j = 0; j < N; j++)
                {
                    count[j] = max_count;
                }
            }
        }
        
        return count;
    }
}