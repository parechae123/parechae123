using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[,] maps) {
        int[] dirX = new int[4]{-1,1,0,0};
        int[] dirY = new int[4]{0,0,-1,1};
        Queue<Tuple<int,int>> path = new Queue<Tuple<int,int>>();
        int[,] dist = new int[maps.GetLength(0),maps.GetLength(1)];
        dist[maps.GetLength(0)-1,maps.GetLength(1)-1] = -1;
        int curX = 0;
        int curY = 0;
        path.Enqueue(Tuple.Create(0,0));
        dist[0,0] = 1;
        while(true)
        {
            int lastX =0;
            int lastY = 0;
            for(int i = 0; i< dirX.Length; i++)
            {
                int nextX = dirX[i]+curX;
                int nextY = dirY[i]+curY;
                
                if(nextX < 0||nextX >= maps.GetLength(0)) continue;
                if(nextY < 0||nextY >= maps.GetLength(1)) continue;
                
                if(maps[nextX,nextY] == 0) continue;
                else if(maps[nextX,nextY] == 1 && dist[nextX,nextY] <= 0)
                {

                    lastX = nextX;
                    lastY = nextY;
                    dist[nextX,nextY] = dist[curX,curY]+1;
                    path.Enqueue(Tuple.Create(nextX,nextY));
                }
            }
            
            if(path.Count> 0)
            {
                Tuple<int,int> tempTup = path.Dequeue();
                curX = tempTup.Item1;
                curY = tempTup.Item2;
            }
            else
            {
                break;
            }
            
            //목표 도착 시 while문 탈출
            if(curX == maps.GetLength(0)-1&&curY == maps.GetLength(1)-1)break;
        }
        return dist[maps.GetLength(0)-1, maps.GetLength(1)-1];
    }
}