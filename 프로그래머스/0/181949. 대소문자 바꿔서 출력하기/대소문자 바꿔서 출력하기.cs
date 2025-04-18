using System;
using System.Linq;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        Console.WriteLine(s.Select(x => char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x)).ToArray());
        //대문자 65~96 ,97~
    }
}