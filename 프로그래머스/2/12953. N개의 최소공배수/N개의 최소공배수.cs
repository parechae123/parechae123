using System;
public class Solution {
    //호제법
    //a%b = n1
    //n1%
    public int solution(int[] arr) {
        int answer = arr[0];
        if(arr.Length == 1) return answer;//배열이 하나짜리면 그 자체가 공배수니까 패스
        
        answer = (arr[0]*arr[1])/GCD(arr[0],arr[1]);//유클리드 호재법을 이용하여 두 수를 먼저 곱하고 최소공약수로 나눠줌
        
        if( arr.Length > 2)//두개 이상일때
        {
            for(byte i = 2; i< arr.Length; i++)
            {
                answer = (answer*arr[i]) / GCD(answer,arr[i]);
            }
        }
        
    
        return answer;
    }
    //공약수를 구하고 a에서 b를 나눴을때 남은 수를 b에 다음 회차에서 b를 r로 나눠서 남은 수를 a에 대입 
    int GCD (int a, int b)
    {
        if(b == 0)return a;
        else return GCD(b,a%b);
    }
}
