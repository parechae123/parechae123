using System;

public class Solution {
    int[] dY = new int[4]{1,-1,0,0};
    int[] dX = new int[4]{0,0,1,-1};
    int ySize;
    int xSize;
    public int solution(int[,] board, int[] aloc, int[] bloc) {
        ySize = board.GetLength(0);
        xSize = board.GetLength(1);
        return Move(board,aloc[0],aloc[1],bloc[0],bloc[1]).Item1;
    }
    public (int,bool) Move(int[,] map,int aY,int aX , int bY,int bX)
    {
        if(map[aY,aX] == 0) return (0,false);
        int minWin = int.MaxValue;
        int maxLoose = 0;
        bool canWin = false;
        
        for(int i = 0; i<dY.Length;i++)
        {
            int cY = dY[i]+aY;
            int cX = dX[i]+aX;
            if(cY < 0 || cX < 0 || cY >= ySize || cX >= xSize)continue;
            if(map[cY,cX] == 0)continue;
            map[aY,aX] = 0;
            var (opStep, opWin) = Move(map,bY,bX,cY,cX);
            map[aY,aX] = 1;
            
            if(!opWin)//상대가 질때 나는 이기므로
            {
                canWin = true;
                minWin = Math.Min(minWin,opStep+1);//현재회차의 수를 더해줌
            }
            else if(!canWin)
            {
                maxLoose = Math.Max(maxLoose,opStep+1);
            }
        }
        return canWin? (minWin,true):(maxLoose,false);
        
    }
}