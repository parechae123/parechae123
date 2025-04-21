using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string[] solution(string[] strArr) {
        List<string> tempList = strArr.ToList<string>();
        tempList.RemoveAll(x=> x.Contains("ad"));
        return tempList.ToArray();
    }
}