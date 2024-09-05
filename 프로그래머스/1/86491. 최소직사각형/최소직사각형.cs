using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[,] sizes) {
        List<int[]> sizeList = new List<int[]>();
        for(int i = 0; i<sizes.GetLength(0);i++)
        {
            sizeList.Add(new int[2]);
            sizeList[i][0] = sizes[i,0];
            sizeList[i][1] = sizes[i,1];
            if(sizeList[i][1] > sizeList[i][0])
            {
                sizeList[i][1] = sizes[i,0];
                sizeList[i][0] = sizes[i,1];                
            }
        }
        
        return sizeList.Max((x)=>x[0])*sizeList.Max((x)=>x[1]);
    }
}