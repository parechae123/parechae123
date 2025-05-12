using System;
using System.Linq;

public class Solution {
    public string solution(string[] str_list, string ex){
        return string.Concat(str_list.Where(x=> !x.Contains(ex)));
    }
}