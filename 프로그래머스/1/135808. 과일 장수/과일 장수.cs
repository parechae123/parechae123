using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        Array.Sort(score,(item1,item2)=>item2.CompareTo(item1));
        List<int[]> boxes = new List<int[]>();
        for(int i = 0; i <score.Length/m; i++)
        {
            boxes.Add(new int[m]);
            for(int j = 0; j< m; j++)
            {
                boxes[i][j] = score[(i*m)+j];
                //Console.WriteLine(boxes[i][j]);
            }
            answer += (boxes[i].Min()*boxes[i].Length);
        }

        return answer;
    }
    
}