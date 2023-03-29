namespace CyclicRotation;

public class SolutionClass
{
    public int[] Solution(int[] A, int K)
    {
        for (var j = 0; j < K; j++)
        {
            var last = A[A.Length - 1]; 
        
            for (var i = A.Length - 1; i > 0; i--)
            {
                A[i] = A[i - 1];
            }

            A[0] = last;
        }
        
        return A;
    }
}