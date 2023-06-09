﻿namespace FrogRiver;
using System.Collections.Generic;
using System.Linq;

public class SolutionClass
{
    public int Solution(int X, int[] A)
    {
        var temp = new HashSet<int>();

        for (var i = 0; i < X; i++)
        {
            temp.Add(i + 1);
        }

        for (var i = 0; i < A.Length; i++)
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