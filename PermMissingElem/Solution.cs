﻿namespace PermMissingElem;

public class SolutionClass
{
    public int Solution(int[] A)
    {
        var s = 0;
        var s2 = 0;
        int i;

        for (i = 0; i < A.Length; i++)
        {
            s += A[i];
            s2 += i + 1;
        }

        i++;
        s2 += i;

        return s2 - s;
    }
}