using System;
using System.Collections.Generic;
using System.Linq; 
//배열이 비어있으면 arr[i]를 추가하고 다음 인덱스로
    //배열이 안비어있고 stk.Last < arr[i]이면 arr[i]를 addLast(arr[i])
    //배열이 안비어있고 stk.Last >= arr[i]이면 arr[i]를 RemoveLast()
public class Solution {
    public int[] solution(int[] arr) {
        LinkedList<int> stk = new LinkedList<int>();
        for(int i = 0; i< arr.Length; i++)
        {
            if(stk.Count <= 0)
            {
                stk.AddLast(arr[i]);
            }
            else
            {
                if(stk.Last() < arr[i])
                {
                    stk.AddLast(arr[i]);
                }
                else
                {
                    i--;
                    stk.RemoveLast();
                }
            }
        }
        return stk.ToArray();
    }
}