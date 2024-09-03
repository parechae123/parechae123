using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) 
    {
        int[] answer = new int[2];
        char[,] map = new char[park.Length,park[0].Length];
        int xPosition = 0;
        int yPosition = 0;
        for(int i = 0; i< map.GetLength(0); i++)
        {
            for(int j = 0; j< map.GetLength(1); j++)
            {
                map[i,j] = park[i][j];
                if(park[i][j] == 'S')
                {
                    yPosition = i;
                    xPosition = j;
                }
            }
        }
        Console.WriteLine("x포지션 초기값"+xPosition+"y포지션 초기값" + yPosition);
        for(int i = 0; i< routes.Length;i++)
        {
            int movePoint = int.Parse(routes[i][2].ToString());
            int temp = 0;
            int xSavePoint = xPosition;
            int ySavePoint = yPosition;
            for(;movePoint > 0;movePoint--)
            {
                if(routes[i][0] == 'E'||routes[i][0] == 'W')
                {
                    
                    temp = routes[i][0] == 'E'?1:-1;
                    Console.WriteLine("x"+(xPosition+(temp*movePoint)));
                    if(xPosition+(temp*movePoint) < 0 ||xPosition+(temp*movePoint)>= map.GetLength(1))
                    {
                        break;
                    }

                    if(xPosition+temp > -1 &&xPosition+temp< map.GetLength(1))
                    {
                        if(map[yPosition,xPosition+temp] =='X')
                        {
                            xPosition = xSavePoint;
                            break;
                        }
                        else
                        {
                            xPosition = xPosition+temp; 
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else if(routes[i][0] == 'S'||routes[i][0] == 'N')
                {
                    temp = routes[i][0] == 'S'?1:-1;
                    Console.WriteLine("Y"+(yPosition+(temp*movePoint)));
                    Console.WriteLine(temp);
                    if(yPosition+(temp*movePoint) < 0 ||yPosition+(temp*movePoint)>= map.GetLength(0))
                    {
                        break;
                    }
                    if(yPosition+temp > -1 &&yPosition+temp< map.GetLength(0))
                    {
                        if(map[yPosition+temp,xPosition] =='X')
                        {
                            yPosition = ySavePoint;
                            break;
                        }
                        else
                        {
                            yPosition = yPosition+temp; 
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                temp = 0;
            }
        }
        answer[0] = yPosition;
        answer[1] = xPosition;
        return answer;
    }
}