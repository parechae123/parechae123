using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] babbling) {
        string[] speakAbleWords = new string[4]{"aya", "ye", "woo", "ma"};
        for(int i = 0; i < babbling.Length; i++)
        {
            for(int j = 0; j< speakAbleWords.Length; j++)
            {
                babbling[i]=babbling[i].Replace(speakAbleWords[j],j.ToString());
            }
        }
        int answer = 0;
        for(int i = babbling.Length-1; 0 <= i; i--)
        {
            char currChar = 'a';
            for(int j = babbling[i].Length-1; 0 <=j; j--)
            {
                if(babbling[i][j] != currChar)
                {
                    if(babbling[i][j] =='0'||babbling[i][j] =='1'
                       ||babbling[i][j] =='2'||babbling[i][j] =='3')
                    {
                        currChar = babbling[i][j];
                    }
                    else break;
                }
                else break;
                
                if(j == 0)answer++;
            }
        }

        return answer;
    }
}