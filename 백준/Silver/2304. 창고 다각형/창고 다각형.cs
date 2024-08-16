using System;
using System.IO;
using System.Text;
using System.Collections.Generic;



namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int pillarCount = int.Parse(Console.ReadLine());
            if (pillarCount > 1000 || pillarCount <= 0) return;
            (int, int)[] pillarPoints = new (int, int)[pillarCount];
            (int, int) maxPoint = (0, 0);
            for (int i = 0; i < pillarCount; i++)
            {
                string[] tempPosition = Console.ReadLine().Split();
                pillarPoints[i].Item1 = int.Parse(tempPosition[0]);
                pillarPoints[i].Item2 = int.Parse(tempPosition[1]);
                if (maxPoint.Item1 < pillarPoints[i].Item1)
                {
                    maxPoint.Item1 = pillarPoints[i].Item1;
                }
                if (maxPoint.Item2 < pillarPoints[i].Item2)
                {
                    maxPoint.Item2 = pillarPoints[i].Item2;
                }
            }
            if (maxPoint.Item1 > 1000 || maxPoint.Item1 <= 0 || maxPoint.Item2 > 1000 || maxPoint.Item2 <= 0) return;
            bool[,] pillarPosition = new bool[maxPoint.Item1+1, maxPoint.Item2+1];
            for (int j = 0; j < pillarPoints.Length; j++)
            {
                pillarPosition[pillarPoints[j].Item1, pillarPoints[j].Item2] = true;
                for (int i = 0; i < pillarPoints[j].Item2; i++)
                {
                    pillarPosition[pillarPoints[j].Item1, i] = true;
                }
            }
            int bound = 0;
            for (int i = 1; i < pillarPosition.GetLength(1); i++)
            {
                bool isPillarStarted = false;
                int xMax = 0;

                for (int j = 0; j < pillarPosition.GetLength(0); j++)
                {
                    if (pillarPosition[j, i])
                    {
                        //끝점과
                        xMax = j;
                    }
                }
                for (int j = 0; j < pillarPosition.GetLength(0); j++)
                {
                    //시작점
                    if (pillarPosition[j, i])
                    {
                        xMax -= j;
                        bound += (xMax+1);
                        break;
                    }
                }
            }
            
            Console.WriteLine(bound);
            Console.ReadLine();
        }
    }
}