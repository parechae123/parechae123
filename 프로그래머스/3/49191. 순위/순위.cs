using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int n, int[,] results) {
        int answer = 0;
        sbyte[,] battleResult = new sbyte[n+1,n+1];
        for(short i = 0; i < results.GetLength(0);i++)
        {
            battleResult[results[i,0],results[i,1]] = 1;
            battleResult[results[i,0],0]++;
            battleResult[results[i,1],results[i,0]] = -1;
            battleResult[results[i,1],0]++;
        }
        for(short i = 1; i < battleResult.GetLength(0);i++)
        {
            List<int> looseMatches = new List<int>();
            List<int> wonMatches = new List<int>();
            for(short j = 1; j < battleResult.GetLength(1);j++)
            {
                if(battleResult[i,j] != 0)
                {
                    if(battleResult[i,j] == 1)
                    {
                        wonMatches.Add(j);
                    }
                    else if(battleResult[i,j] == -1)
                    {
                        looseMatches.Add(j);
                    }
                }
                
                if(battleResult.GetLength(1)-1 == j)
                {
                    Console.WriteLine($"{j}열 도는중");
                    for(short k = 0; k < wonMatches.Count; k++)
                    {
                        for(short l = 0; l< looseMatches.Count; l++)
                        {
                            if(battleResult[wonMatches[k],looseMatches[l]] != 0 )continue;
                            battleResult[wonMatches[k],looseMatches[l]] = -1;
                            battleResult[wonMatches[k],0]++;
                            
                            if(battleResult[looseMatches[l],wonMatches[k]] != 0 )continue;
                            battleResult[looseMatches[l],wonMatches[k]] = 1;
                            battleResult[looseMatches[l],0]++;
                        }
                    }
                }
            }
        }
        
        //DebugFunc(battleResult);
        for(sbyte i = 0; i< battleResult.GetLength(0); i++)
        {
            if(battleResult[i,0] >= n-1) answer++;
        }
        return answer;
    }
    
    
    
    
    
    
    
    public void DebugFunc(sbyte[,] targetArray)
    {
        for(int i = 1; i< targetArray.GetLength(0); i++)
        {
            Console.WriteLine(targetArray[i,0]);
            for(int j = 1; j< targetArray.GetLength(1); j++)
            {
                
                if(targetArray[i,j] == 0)
                {
                    if(targetArray.GetLength(1)-1 == j)
                    {
                        Console.WriteLine(" 0");
                        continue;
                    }


                    Console.Write(" 0");
                }
                
                if(targetArray[i,j] != 0)
                {
                    if(targetArray.GetLength(1)-1 == j)
                    {
                        Console.WriteLine(targetArray[i,j] == 1 ? " 1": "-1");
                        continue;
                    }


                    Console.Write(targetArray[i,j] == 1 ? " 1": "-1");
                }
                
            }
        }
    }
}