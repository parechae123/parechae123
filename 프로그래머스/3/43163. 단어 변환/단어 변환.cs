using System;

public class Solution {
    public int solution(string begin, string target, string[] words) {
        int answer = 0;
        bool[] visCheck = new bool[words.Length];
        answer = BFS(ref begin,ref visCheck,target,words);
        return answer;
    }
    
    
    public int BFS(ref string begin,ref bool[] visCheck,string target,string[] words)
    {
        int count = 0;
        for(int i =0; i<words.Length; i++)
        {
            if(visCheck[i])continue;
            int gap = GetCharGap(begin,words[i]);
            if(gap <= 1)
            {
                if(GetCharGap(target,words[i]) < GetCharGap(begin,target))
                {
                    begin = words[i];
                    count++;
                    visCheck[i] = true;
                    count += BFS(ref begin,ref visCheck,target,words);
                }
            }
        }
        return count;
    }
    int GetCharGap(string firWord,string secWord)
    {
        int gap = 0;
        for(int i = 0; i< firWord.Length; i++)
        {
            if(firWord[i] != secWord[i]) gap++;
        }
        return gap;
    }
}