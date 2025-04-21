using System;

public class Solution {
    //인덱스 s부터는 overwrite_string으로 덮어씌어야함
    public string solution(string my_string, string overwrite_string, int s) {
        return my_string.Remove(s,overwrite_string.Length).Insert(s,overwrite_string);
    }
}