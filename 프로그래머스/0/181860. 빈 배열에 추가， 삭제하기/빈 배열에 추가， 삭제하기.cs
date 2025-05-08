using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, bool[] flag) {
        LinkedList<int> answer = new LinkedList<int>();
        for(int i = 0; i<arr.Length; i++)
        {
            for(int j = 0; j< arr[i]; j++)
            {
                if(flag[i])
                {
                    answer.AddLast(arr[i]);
                    answer.AddLast(arr[i]);
                }
                else 
                {
                    answer.RemoveLast();
                }
            }
        }
        return answer.ToArray();
    }
}