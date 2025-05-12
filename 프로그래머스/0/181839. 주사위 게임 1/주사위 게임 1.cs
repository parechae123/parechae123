using System;

public class Solution {
    public int solution(int a, int b) {
        return a % 2 == 1 && b % 2 ==1 ? (a*a) + (b*b) 
            :a % 2 == 1 || b % 2 ==1 ? 2*(a+b) : Math.Abs(a-b);
    }
}