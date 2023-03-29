﻿namespace PermMissingElem;

public class Solution
{
    public int solution(int[] A)
    {
        int[] temp = new int[A.Length];
        int sum = Int32.MaxValue;

        temp[0] = A[0];

        if (A.Length == 2)
        {
            return Math.Abs(A[0] - A[1]);
        }
        
        for (int i = 1; i < A.Length; i++)
        {
            temp[i] = A[i] + temp[i - 1];
        }

        for (int i = 0; i < temp.Length; i++)
        {
            if (Math.Abs(temp[i] - (temp[temp.Length - 1] - temp[i])) < sum)
            {
                sum = Math.Abs(temp[i] - (temp[temp.Length - 1] - temp[i]));
            }
        }
        
        return sum;
    }
}