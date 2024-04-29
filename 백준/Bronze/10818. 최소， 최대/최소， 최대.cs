using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            int arraySize = int.Parse(Console.ReadLine());
            string[] arrayString = new string[arraySize];
            int[] arrayNum = new int[arraySize];
            arrayString = Console.ReadLine().Split();
            for (int i = 0; i < arraySize; i++)
            {
                arrayNum[i] = int.Parse(arrayString[i]); 
            }
            Array.Sort(arrayNum);

            Console.WriteLine(arrayNum[0] + " " + arrayNum[arraySize - 1]);
        }
    }
}
