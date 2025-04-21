using System;
using System.Linq;

public class Solution {
    //length > 11 합
    //length < 11 곱
    public int solution(int[] num_list) {
        return num_list.Length >= 11? num_list.Sum():num_list.Aggregate((total,x)=> total*x);
    }
}