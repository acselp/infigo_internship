namespace CyclicRotation;

public class Solution
{
    public int[] solution(int[] A, int K)
    {
        for (int j = 0; j < K; j++)
        {
            int last = A[A.Length - 1]; 
        
            for (int i = A.Length - 1; i > 0; i--)
            {
                A[i] = A[i - 1];
            }

            A[0] = last;
        }
        
        return A;
    }
}