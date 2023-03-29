namespace FrogRiver;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int X, int[] A)
    {
        HashSet<int> temp = new HashSet<int>();

        int i;
        
        for (i = 0; i < X; i++)
        {
            temp.Add(i + 1);
        }

        for (i = 0; i < A.Length; i++)
        {
            if (temp.Contains(A[i]))
            {
                temp.Remove(A[i]);
            }

            if (temp.Count == 0)
            {
                return i;
            }
        }

        return -1;
    }
}