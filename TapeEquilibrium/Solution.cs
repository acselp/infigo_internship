namespace PermMissingElem;

public class SolutionClass
{
    public int Solution(int[] A)
    {
        int[] _temp = new int[A.Length];
        int _sum = Int32.MaxValue;

        _temp[0] = A[0];

        if (A.Length == 2)
        {
            return Math.Abs(A[0] - A[1]);
        }
        
        for (int i = 1; i < A.Length; i++)
        {
            _temp[i] = A[i] + _temp[i - 1];
        }

        for (int i = 0; i < _temp.Length; i++)
        {
            if (Math.Abs(_temp[i] - (_temp[_temp.Length - 1] - _temp[i])) < _sum)
            {
                _sum = Math.Abs(_temp[i] - (_temp[_temp.Length - 1] - _temp[i]));
            }
        }
        
        return _sum;
    }
}