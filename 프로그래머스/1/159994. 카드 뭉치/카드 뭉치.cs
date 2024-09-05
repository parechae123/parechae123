using System;
using System.Collections.Generic;

public class Solution {
    //카드1의 배열
    //카드2의 배열
    //각 배열에 마지막으로 사용 된 숫자보다 큰 배열을 사용 할 수 없음
    public string solution(string[] cards1, string[] cards2, string[] goal) 
    {
        string answer = "Yes";

        Dictionary<string,card> dict = new Dictionary<string,card>();
        for(int i = 0;i<cards1.Length;i++)
        {
            card tempCard = new card(1,i);
            dict.Add(cards1[i],tempCard);
        }
        for(int i = 0;i<cards2.Length;i++)
        {
            card tempCard = new card(2,i);
            dict.Add(cards2[i],tempCard);
        }        
        int currNumOne = -1;
        int currNumTwo = -1;
        for(int i = 0; i<goal.Length; i++)
        {
            if(dict.ContainsKey(goal[i]))
            {
                if(dict[goal[i]].deckNum == 1)
                {
                    if(currNumOne < dict[goal[i]].arrayNum)
                    {
                        if(dict[goal[i]].arrayNum-currNumOne > 1) return "No";
                        currNumOne = dict[goal[i]].arrayNum;
                    }
                    else
                    {
                        return "No";
                    }
                }
                else if(dict[goal[i]].deckNum == 2)
                {
                    if(currNumTwo < dict[goal[i]].arrayNum)
                    {
                        if(dict[goal[i]].arrayNum-currNumTwo > 1) return "No";
                        currNumTwo = dict[goal[i]].arrayNum;
                    }
                    else
                    {
                        return "No";
                    }                    
                }
            }
            else
            {
                return "No";
            }
        }
        return answer;
    }
}
public struct card
{
    public int deckNum;
    public int arrayNum;
    public card(int deckNum,int arrayNum)
    {
        this.deckNum = deckNum;
        this.arrayNum = arrayNum;
    }
}