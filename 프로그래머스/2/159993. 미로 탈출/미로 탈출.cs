using System;
using System.Collections.Generic;

public class Solution {
    int[] dX = new int[4]{1,-1,0,0};
    int[] dY = new int[4]{0,0,1,-1};
    public int solution(string[] maps) {
        int[] goalX = new int[3];
        int[] goalY = new int[3];
        
        for(int i = 0; i< maps.Length; i++)
        {
            for(int j =0; j< maps[i].Length; j++)
            {
                int curIdx = -1;
                if(maps[i][j] == 'S')curIdx = 0;
                else if(maps[i][j] == 'L')curIdx =1;
                else if(maps[i][j] == 'E')curIdx =2;
                
                if(curIdx != -1)
                {
                    goalX[curIdx] =i;
                    goalY[curIdx] =j;
                }
            }
        }
        
        int lStep = BFS(goalX[0],goalY[0],maps,'L');
        int eStep = BFS(goalX[1],goalY[1],maps,'E');
        
        
        return lStep == -1|| eStep == -1 ? -1 : lStep+eStep;
    }
    
    public int BFS(int fX,int fY,string[] maps, char target)
    {
        Queue<int> xQueue = new Queue<int>();
        Queue<int> yQueue = new Queue<int>();
        xQueue.Enqueue(fX);
        yQueue.Enqueue(fY);
        
        int xMax = maps.Length;
        int yMax = maps[0].Length;
        int[,] visitMap = new int[xMax,yMax];
        
        visitMap[fX,fY] = 0;
            
        while(xQueue.Count> 0)
        {
            int curX = xQueue.Dequeue();
            int curY = yQueue.Dequeue();
            for(int i = 0; i<dX.Length;i++)
            {
                int tempX = curX+dX[i];
                int tempY = curY+dY[i];
                
                if(xMax <= tempX || tempX < 0) continue;
                else if(yMax <= tempY || tempY < 0) continue;
                
                if(maps[tempX][tempY] == 'X') continue;
                
                if(visitMap[tempX,tempY] != 0) continue;
                
                visitMap[tempX,tempY] = visitMap[curX,curY]+1;
                
                xQueue.Enqueue(tempX);
                yQueue.Enqueue(tempY);
                
                if(maps[tempX][tempY] == target)return visitMap[tempX,tempY];
            }
        }
        return -1;
    }
}