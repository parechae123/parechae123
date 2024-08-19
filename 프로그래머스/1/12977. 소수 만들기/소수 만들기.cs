using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = -1;
        List<int> mixResults = new List<int>();
        for(int i = 0; i< nums.Length; i++)
        {
            for(int j = i+1; j< nums.Length; j++)
            {
                for(int k = j+1; k< nums.Length; k++)
                {
                    int tempResult = 0;
                    tempResult += nums[i];
                    tempResult += nums[j];
                    tempResult += nums[k];
                    mixResults.Add(tempResult);
                }
            }
        }
        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        answer = mixResults.Count;
        for(int i = 0; i< mixResults.Count; i++)
        {
            
            for(int j = 2; j< mixResults[i]; j++)
            {   
                if(mixResults[i]%j == 0)
                {
                    
                    answer--;
                    break;
                }
            }
        }

        
        //소수를 구해야 하니 nums를 각각 더한 임의의 수를 담는 int배열이 필요
        //일단 경우의 수는 (nums.Length/나누는 갯수)
        return answer;
    }
}