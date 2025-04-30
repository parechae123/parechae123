using System;
using System.Linq;

public class Solution {
    //5명씩 묶음
    public string[] solution(string[] names) {
        return names.Where((name,index)=> 0==(index%5)).ToArray();
    }
}