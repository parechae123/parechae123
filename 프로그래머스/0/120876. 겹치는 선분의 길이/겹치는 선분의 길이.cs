using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[,] lines) {
        int[] flatLine = Enumerable.Repeat(0,lines.GetLength(0)*lines.GetLength(1))
            .Select((num,idx)=> lines[idx/lines.GetLength(1),idx%lines.GetLength(1)]).ToArray();
        
        int min = flatLine.Min();
        int max = flatLine.Max();
        
        min = min < 0? Math.Abs(min): 0;
        max += min;
        
        int[] map = Enumerable.Repeat(0,max).ToArray();
        for(int i = 0; i< flatLine.Length; i+=2)
        {
            for(int j = flatLine[i]+min; j<flatLine[i+1]+min; j++)
            {
                map[j]++;
            }
        }
        return map.Count((x)=>x> 1);
    }
}