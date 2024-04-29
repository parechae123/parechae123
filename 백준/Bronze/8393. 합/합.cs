using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string sendedValue = Console.ReadLine();
            int parsedValue = int.Parse(sendedValue);
            int returnValue = 0;

            for (int i = 0; i <= parsedValue; i++)
            {
                returnValue += i;
            }
            Console.WriteLine(returnValue);

        }
    }
}
