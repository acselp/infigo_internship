namespace MissingIntegers;

public class SolutionClass
{
    public int Solution(int[] A)
    {
        int[] _temp = new int[A.Length];
        int _min_int = Int32.MaxValue;
        
        for (int i = 0; i < A.Length; i++)
        {
            _temp[i] = i + 1;
        }

        for (int i = 0; i < A.Length; i++)
        {
            if (!A.Contains(_temp[i]) && _min_int > (i + 1))
            {
                _min_int = i + 1;
            }
        }

        if (_min_int == Int32.MaxValue)
        {
            _min_int = A.Length + 1;
        }

        return _min_int;
    }
}