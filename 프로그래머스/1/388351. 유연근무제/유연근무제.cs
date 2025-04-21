using System;

public class Solution {
    public int solution(int[] schedules, int[,] timelogs, int startday) {
        int answer = 0;
        //시작일자에 매칭이 되어있음
        //timeLog의 2차원 영역은 startday기준으로 시작
        int sunday = (7-startday < 0)? 0 : 7-startday;
        int saturday = (6-startday < 0)? 6 : 6-startday;
        for(int i = 0; i< schedules.Length; i++)
        {
            int timeLimit = schedules[i] % 100 < 50? schedules[i]+10:schedules[i]+ 50;
            bool isLate = false;
            for(int j = 0; j< timelogs.GetLength(1); j++)
            {
                if(j == sunday || j == saturday)
                {
                    continue;
                }
                
                if(timeLimit < timelogs[i,j])
                {
                    isLate = true;
                    break;
                }
            }
            if(!isLate)answer++;
        }
        return answer;
    }
}