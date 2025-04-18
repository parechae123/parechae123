using System;
using System.Linq;
public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        s.ToList().ForEach(x => Console.Write(x+("\n")));

    }
}