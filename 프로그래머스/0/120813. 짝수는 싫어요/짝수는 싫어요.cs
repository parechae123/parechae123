using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        int[] answer = Enumerable.Range(1,n%2 == 0? n/2: (n+1)/2).ToArray();
        answer = answer.Select(x=>(x*2)-1).ToArray();
        return answer;
    }
}