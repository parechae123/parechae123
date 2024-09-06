using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] answers) {
        int[] studentOne = new int[] {1, 2, 3, 4, 5};
        int[] studentTwo = new int[] {2, 1, 2, 3, 2, 4, 2, 5};
        int[] studentThree = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5,5};
        int[] scores = new int[3];
        for(int i = 0; i<answers.Length;i++)
        {
            if(studentOne[i%studentOne.Length] == answers[i])       scores[0]++;
            if(studentTwo[i%studentTwo.Length] == answers[i])       scores[1]++;
            if(studentThree[i%studentThree.Length] == answers[i])   scores[2]++;
        }
        
        List<int> answer = new List<int>();
        if(scores[0] == scores.Max())answer.Add(1);
        if(scores[1] == scores.Max())answer.Add(2);
        if(scores[2] == scores.Max())answer.Add(3);
        return answer.ToArray();
    }
}