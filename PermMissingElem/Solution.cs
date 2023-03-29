namespace PermMissingElem;

public class SolutionClass
{
    public int Solution(int[] A)
    {
        int _s = 0;
        int _s2 = 0;
        int _i;

        for (_i = 0; _i < A.Length; _i++)
        {
            _s += A[_i];
            _s2 += _i + 1;
        }

        _i++;
        _s2 += _i;

        return _s2 - _s;
    }
}