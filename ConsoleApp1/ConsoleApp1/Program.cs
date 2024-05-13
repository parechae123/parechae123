using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int arrayCount = int.Parse(Console.ReadLine());
            int[] arrayIntA = new int[9];
            StringBuilder tempSTB = new StringBuilder();
            //0 < A, B < 10
            for (int i = 0; i < 9; i++)
            {
                arrayIntA[i] = arrayCount * (i+1);
                tempSTB.AppendLine(arrayCount + " * " +(i+1)+" = "+ (arrayIntA[i]).ToString());
            }

            
            Console.WriteLine(tempSTB.ToString());
        }
        /*
        static void Main()
        {
            int arrayCount = int.Parse(Console.ReadLine());
            int[] arrayIntA = new int[arrayCount];
            int[] arrayIntB = new int[arrayCount];
            StringBuilder tempSTB = new StringBuilder();
            string[] tempString = new string[2];
            //0 < A, B < 10
            for (int i = 0; i < arrayCount; i++)
            {
                tempString = Console.ReadLine().Split();
                arrayIntA[i] = int.Parse(tempString[0]);
                arrayIntB[i] = int.Parse(tempString[1]);
                if (arrayIntA[i] <= 0 || arrayIntB[i] >= 10)
                {
                    return;
                }
                tempSTB.AppendLine((arrayIntA[i] + arrayIntB[i]).ToString());
            }

            
            Console.WriteLine(tempSTB.ToString());
        }*/
    }
}
