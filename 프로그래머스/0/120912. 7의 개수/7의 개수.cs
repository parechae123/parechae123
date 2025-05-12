using System;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
        int answer = array.Select(x=>x.ToString().Count(y=>y=='7')).Sum();
        
        return answer;
    }
}