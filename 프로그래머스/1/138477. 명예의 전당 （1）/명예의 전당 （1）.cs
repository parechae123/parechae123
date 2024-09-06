using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    //가장 마지막배열을 넣으면됨
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> temp = new List<int>();
        for(int i = 0; i<score.Length; i++)
        {
            temp.Add(score[i]);
            temp = temp.OrderByDescending(x=>x).ToList();
            if(temp.Count>k) answer[i]= temp[k-1];
            else answer[i]= temp.Last();
        }
        return answer;
    }
}