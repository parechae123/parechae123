using System;

public class Solution {
    //1번부터 던짐, 다음배열을 건너뛸때 k 회차엔 누가 공을 던지는가
    //짝수 == 반복, 홀수 
    //[1][3][2]
    //
    public int solution(int[] numbers, int k) {
        return numbers[(((k-1)*2))%numbers.Length];
    }
}
