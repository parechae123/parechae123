using System;
using System.Linq;

public class Solution {
    public int solution(string binomial) {
        int answer = 0;
        for(int i = '*'; i<= '-';i++)
        {
            if(i == 44) continue;
            int operIdx = binomial.IndexOf((char)i);
            if(operIdx == -1)continue;
            
            string[] numbers = binomial.Split((char)i);
            switch((char)i)
            {
                case '-':
                    answer = int.Parse(numbers[0]) - int.Parse(numbers[1]);
                    break;
                case '+':
                    answer = int.Parse(numbers[0]) + int.Parse(numbers[1]);
                    break;
                case '*':
                    answer = int.Parse(numbers[0]) * int.Parse(numbers[1]);
                    break;
            }
            break;
        }
        return answer;
    }
}