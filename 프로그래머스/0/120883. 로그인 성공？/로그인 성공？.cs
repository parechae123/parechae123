using System;
using System.Linq;

public class Solution {
    //정보가 있으면 login출력, 동일 아이디x fail,아이디는 있으나 패스워드 일치x == wrong pw
    public string solution(string[] id_pw, string[,] db) {
        string[] idDB = Enumerable.Repeat("",db.GetLength(0)).Select((str,idx)=> db[idx,0]).ToArray();
        string[] pwDB = Enumerable.Repeat("",db.GetLength(0)).Select((str,idx)=> db[idx,1]).ToArray();
        int idIdx = Array.IndexOf(idDB,id_pw[0]);
        int pwIdx = idIdx >= 0&&pwDB[idIdx] == id_pw[1]? idIdx : -1;
        return idIdx < 0? "fail" : 
        idIdx == pwIdx ? "login" : "wrong pw";
    }
}