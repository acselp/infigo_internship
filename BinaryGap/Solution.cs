namespace BinaryGap;

public class SolutionClass
{
    public string Binary { get; set; }
    public int Solution(int N)
    {
        Binary = Convert.ToString(N, 2);

        int _res = 0;
        int _n = 0;

        for (int i = 0; i < Binary.Length; i++)
        {
            if (Binary[i] == '1' )
            {
                if (_n > _res)
                {
                    _res = _n;
                }
                _n = 0;
            }
            else if(Binary[i] == '0')
            {
                _n++;
            }
        }
        return _res;
    }
}