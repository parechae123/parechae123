using System;

public class Solution {
    int answer = 0;
    public int solution(string s) {
        DFS(ref s);
        return answer;
    }
    public void DFS(ref string s)
    {
        if(s.Length<=0)return;
        int sameCharCount =0;
        int diffCharCount =0;
        char targetChar = s[0];
        for(int i = 0; i<s.Length;i++)
        {
            if(s[i] == targetChar)sameCharCount++;
            else
            {
                diffCharCount++;
                if(sameCharCount<=diffCharCount)
                {
                    s = s.Remove(0,i+1);
                    break;
                }
            }
            if(s.Length ==diffCharCount+sameCharCount)
            {
                s = "";
                break;
            }
        }

        answer++;
        DFS(ref s);
    }
}