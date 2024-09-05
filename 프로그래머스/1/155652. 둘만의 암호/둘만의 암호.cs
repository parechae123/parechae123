using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string s, string skip, int index) {

        char[] tempChar = s.ToCharArray();
        List<char> skipValues = new List<char>();
        for(byte i = 0; i< skip.Length;i++)
        {
            skipValues.Add(skip[i]);
        }
        
        for(byte i = 0; i <tempChar.Length; i++)
        {
            for(int k = 0; k <index; k++)
            {
                tempChar[i] = (char)((int)tempChar[i]+1);
                if((int)tempChar[i] > (int)'z') tempChar[i] = (char)((int)tempChar[i]-26);
                while(skipValues.Contains(tempChar[i]))
                {
                    tempChar[i] = (char)((int)tempChar[i]+1);
                    if((int)tempChar[i] > (int)'z') tempChar[i] =(char)((int)tempChar[i]-26);
                    Console.WriteLine(tempChar[i]);
                }
            }
        }
        
        Console.WriteLine(skipValues.Contains(tempChar[0])+"밖");
        //97<= char&& char >= 122 &&
        string answer = new string(tempChar);
        return answer;
    }
}