using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        Dictionary<string,int> playerSearcher = new Dictionary<string,int>();
        for(int i = 0; i < players.Length;i++)
        {
            playerSearcher.Add(players[i],i);
        }
        int tempInt = 0;
        for(int i = 0; i < callings.Length;i++)
        {
            tempInt = playerSearcher[callings[i]];
            playerSearcher[callings[i]] = tempInt-1;
            playerSearcher[players[tempInt-1]] = tempInt;
            SwapForward(ref players,tempInt);
        }
        return players;
    }
    public void SwapForward(ref string[] names,int origin)
    {
        if(origin <=0) return;
        
        string temp = names[origin-1];
        names[origin-1] = names[origin];
        names[origin] = temp;
    }
}