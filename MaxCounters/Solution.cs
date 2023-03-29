namespace MaxCounters;

public class SolutionClass
{
    public int[] Solution(int N, int[] A)
    {
        int[] _count = new int[N];
        int _max_count = 0;
        
        for (int i = 0; i < N; i++)
        {
            _count[i] = 0;
        }

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] > 0 && A[i] <= N)
            {
                _count[A[i] - 1]++;

                if (_count[A[i] - 1] > _max_count)
                {
                    _max_count = _count[A[i] - 1];
                }
            }
            else if (A[i] == N + 1)
            {
                for (int j = 0; j < N; j++)
                {
                    _count[j] = _max_count;
                }
            }
        }
        
        return _count;
    }
}