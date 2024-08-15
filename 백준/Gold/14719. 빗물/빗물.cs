using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split();
        if (arr.Length !=2) return;
        int maxHeight = int.Parse(arr[0]);
        int[,] mapData = new int[maxHeight, int.Parse(arr[1])];

        arr = Console.ReadLine().Split();
        for (int i = 0; i < mapData.GetLength(1); i++)
        {
            int groundHeight = int.Parse(arr[i]);
            if (groundHeight > maxHeight || mapData.GetLength(1) != arr.Length || groundHeight < 0)
            {
                return;
            }
            for (int j = 0; j < groundHeight; j++)
            {
                mapData[j, i] = 1;
            }
        }
        int bucketBlocks = 0;
        for (int i = 0; i < mapData.GetLength(0); i++)
        {
            bool isStartingWallThere = false;
            int tempBucketBlockCount = 0;
            for (int j = 0; j < mapData.GetLength(1); j++)
            {
                if (mapData[i, j] == 1)
                {
                    if (isStartingWallThere)
                    {
                        bucketBlocks += tempBucketBlockCount;
                        if (tempBucketBlockCount > 0)
                        {
                            isStartingWallThere = false;
                            if (j+1 < mapData.GetLength(1))
                            {
                                if(mapData[i,j + 1] == 0) isStartingWallThere = true;
                            }
                            tempBucketBlockCount = 0;
                        }
                    }
                    else
                    {
                        isStartingWallThere = true;
                    }

                }
                else
                {
                    if (isStartingWallThere)
                    {
                        tempBucketBlockCount++;
                    }
                }
            }
        }


        Console.WriteLine(bucketBlocks.ToString());
        Console.ReadLine();
    }
}