using System;
public class Solution {
    //홀수번째 = 대문자, 짝수번째 소문자
    public string[] solution(string[] strArr) {
        for(int i = 0; i < strArr.Length ;i++)
        {
            if((i %2) == 1)strArr[i] = strArr[i].ToUpper();
            else strArr[i] = strArr[i].ToLower();
        }
        return strArr;
    }
}