using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];
        for(int i = 0; i< queries.GetLength(0);i ++)
        {
            answer[i] = int.MaxValue;
            for(int j = queries[i,0]; j <= queries[i,1]; j++)
            {
                answer[i] = arr[j] < answer[i] && queries[i,2] < arr[j]? arr[j]:answer[i];
            }
            answer[i] = answer[i] == int.MaxValue? -1: answer[i];
        }
        return answer;
    }
}