
namespace OddOccurrencesInArray;
using System.Collections.Generic;
using System.Linq;


public class Solution
{
    public int solution(int[] A)
    {
        HashSet<int> temp = new HashSet<int>();

        for (int i = 0; i < A.Length; i++)
        {
            if (!temp.Contains(A[i]))
            {
                temp.Add(A[i]);
            }
            else
            {
                temp.Remove(A[i]);
            }
        }
        return temp.ElementAt(0);
    }
}