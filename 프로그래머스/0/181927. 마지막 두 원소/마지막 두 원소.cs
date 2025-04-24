using System;

public class Solution {
    public int[] solution(int[] num_list) {
        Array.Resize(ref num_list,num_list.Length+1);
        num_list[num_list.Length-1] =  num_list[num_list.Length-3]>=num_list[num_list.Length-2]?
            num_list[num_list.Length-2]*2:num_list[num_list.Length-2]-num_list[num_list.Length-3];
        return num_list;
    }
}