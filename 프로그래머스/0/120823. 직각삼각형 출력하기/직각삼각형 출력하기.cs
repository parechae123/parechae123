using System;
using System.Linq;
using System.Text;
public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int n = Int32.Parse(s[0]);
        StringBuilder sb = new StringBuilder();
        for(int i =1; i<=n; i++)
        {
            for(int j =1; j<=i; j++)
            {
                sb.Append('*');
            }
            sb.Append('\n');
        }
        Console.WriteLine(sb);
    }
}