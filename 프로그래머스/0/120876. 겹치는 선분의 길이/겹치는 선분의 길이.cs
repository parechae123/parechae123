using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[,] lines) {
        int[] flatArr = Enumerable.Repeat(0,lines.GetLength(0)*lines.GetLength(1))
            .Select((num,idx)=> lines[idx/lines.GetLength(1),idx % lines.GetLength(1)]).ToArray();
        
        int min = flatArr.Min();
        int max = flatArr.Max();
        
        min = min<0? Math.Abs(min):0;
        max += min;
        
        int[] map = Enumerable.Repeat(0,max).ToArray();
        
        for(int i = 0; i < flatArr.Length; i+=2)
        {
            
            for(int j = flatArr[i]+min; j < flatArr[i+1]+min; j++ )
            {
                map[j]++;
            }
        }
        return map.Count(x=> x> 1);
    }
}