namespace MaxCounters;

public class Solution
{
    public int[] solution(int N, int[] A)
    {
        int[] count = new int[N];
        int max_count = 0;
        
        for (int i = 0; i < N; i++)
        {
            count[i] = 0;
        }

        for (int i = 0; i < A.Length; i++)
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
                for (int j = 0; j < N; j++)
                {
                    count[j] = max_count;
                }
            }
        }

        return count;
    }
}