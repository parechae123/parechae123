using System;
using System.Text;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        StringBuilder sb = new StringBuilder();
        //배열의 숫자와 동일하게 대입
        int[] arrayOne = new int[10];
        int[] arrayTwo = new int[10];
        for(int i = 0; i<X.Length; i++)
        {
            arrayOne[(int)(X[i]-'0')]++;
        }
        for(int i = 0; i<Y.Length; i++)
        {
            arrayTwo[(int)(Y[i]-'0')]++;
        }
        for(int i = arrayOne.Length-1; i >= 0; i--)
        {
            while(arrayOne[i] > 0)
            {
                if(arrayOne[i]> 0&&arrayTwo[i]> 0)
                {
                    arrayOne[i]--;
                    arrayTwo[i]--;
                    sb.Append((char)(i+'0'));
                }
                else break;
            }
        }

        answer = sb.ToString();
        if(answer == string.Empty) answer = "-1";
        else if(answer[0] == '0') answer = "0";
       
        return answer;
    }
}