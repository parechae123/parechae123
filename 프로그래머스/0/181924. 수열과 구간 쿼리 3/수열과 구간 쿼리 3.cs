using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        for(int i = 0; i<queries.GetLength(0); i++)
        {
            ArrSwap(arr,queries[i,0],queries[i,1]);
        }
        return arr;
    }
    public void ArrSwap(int[] arr,int idxFrom,int idxTo)
    {
        int temp = arr[idxTo];
        arr[idxTo] = arr[idxFrom];
        arr[idxFrom] = temp;
    }
}