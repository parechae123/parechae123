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
            solution(new int[9] {2, 1, 1, 2, 3, 1, 2, 3, 1 });
        }
        public static int solution(int[] ingredient)
        {
            int answer = 0;
            List<int> list = new List<int>();

            foreach (int burger in ingredient)
            {
                list.Add(burger);
                Console.WriteLine(burger);
                if (list.Count >= 4)
                {
                    if (list[list.Count - 4] == 1 && list[list.Count - 3] == 2
                       && list[list.Count - 2] == 3 && list[list.Count - 1] == 1)
                    {
                        answer++;
                        list.RemoveRange(list.Count - 4, 4);
                    }
                }
            }
            Console.ReadLine();
            return answer;
        }
        /*        public static int solution(string s)
                {
                    int answer = 0;
                    DFS(ref s, answer);
                    Console.WriteLine(s);
                    return answer;
                }
                public static void DFS(ref string s, int subDivedNum)
                {
                    if (s.Length <= 0) return;
                    int sameCharCount = 0;
                    int diffCharCount = 0;
                    char targetChar = s[0];
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] == targetChar) sameCharCount++;
                        else
                        {
                            diffCharCount++;
                            if (sameCharCount < diffCharCount)
                            {
                                s = s.Remove(0, i);
                                break;
                            }
                        }
                    }
                    DFS(ref s, subDivedNum++);
                }*/

    }   
}
