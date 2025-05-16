using System;
using System.Linq;
public class Solution {
    public int solution(int[,] lines) {
        
        int[] dLines = Enumerable.Repeat(0,lines.GetLength(0)*lines.GetLength(1))
            .Select((num,idx)=> lines[idx/lines.GetLength(1),idx%lines.GetLength(1)]).ToArray();
        int min = dLines.Min();
        int max = dLines.Max();
        min = min < 0? Math.Abs(min): 0;
        max += min+1;
        
        dLines = Enumerable.Repeat(0,max).ToArray();
        
        for(int i = 0; i<lines.GetLength(0); i++)
        {
            for(int j = lines[i,0]; j<=lines[i,1]; j++)
            {
                if(lines[i,0] == j)continue;
                dLines[j+min]++;
            }
        }
        Console.WriteLine(string.Join(',',dLines));
        return dLines.Count(x=> x>1);

    }
}