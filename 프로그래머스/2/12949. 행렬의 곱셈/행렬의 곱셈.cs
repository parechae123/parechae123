using System;

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int[,] answer = new int[arr1.GetLength(0),arr2.GetLength(1)];
        for(int i = 0; i<answer.GetLength(0); i++)
        {
            for(int j = 0; j<answer.GetLength(1); j++)
            {
                int result = 0;
                for(int k = 0; k<arr1.GetLength(1); k++)
                {
                    result += arr1[i,k] * arr2[k,j];
                }
                answer[i,j] = result;
            }
        }
        return answer;
    }
}