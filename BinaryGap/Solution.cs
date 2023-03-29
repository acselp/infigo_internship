namespace BinaryGap;

public class SolutionClass
{
    public string Binary { get; set; }
    public int Solution(int N)
    {
        Binary = Convert.ToString(N, 2);

        int res = 0;
        int n = 0;

        for (int i = 0; i < Binary.Length; i++)
        {
            if (Binary[i] == '1' )
            {
                if (n > res)
                {
                    res = n;
                }
                n = 0;
            }
            else if(Binary[i] == '0')
            {
                n++;
            }
        }
        return res;
    }
}