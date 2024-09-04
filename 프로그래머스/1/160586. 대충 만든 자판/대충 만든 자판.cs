using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        Dictionary<char,int> dict = new Dictionary<char,int>();
        for(int i = 0; i<keymap.Length;i++)
        {
            for(int j = 0; j<keymap[i].Length; j++)
            {
                if(dict.ContainsKey(keymap[i][j]))
                {
                    if(dict[keymap[i][j]] > j)
                    {
                        dict[keymap[i][j]] = j+1;
                    }
                    continue;
                }
                else
                {

                    dict.Add(keymap[i][j],j+1);
                }
            }
        }
        for(int i = 0; i < targets.Length;i++)
        {
            for(int j = 0; j<targets[i].Length; j++)
            {
                if(dict.ContainsKey(targets[i][j]))
                {
                    answer[i] += dict[targets[i][j]];
                }
                else
                {
                    answer[i] = -1;
                    break;
                }
            }
        }
        return answer;
    }
}