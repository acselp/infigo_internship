namespace OddOccurrencesInArray;

public class SolutionClass
{
    public int Solution(int[] A)
    {
        HashSet<int> _temp = new HashSet<int>();

        for (int i = 0; i < A.Length; i++)
        {
            if (!_temp.Contains(A[i]))
            {
                _temp.Add(A[i]);
            }
            else
            {
                _temp.Remove(A[i]);
            }
        }
        return _temp.ElementAt(0);
    }
}