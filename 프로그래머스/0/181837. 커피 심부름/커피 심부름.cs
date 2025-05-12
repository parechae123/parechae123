using System;
using System.Linq;

public class Solution {
    //라떼 5000 , 아아 4500
    public int solution(string[] order) {
        int latteCount = order.Where(x=> x.Contains("latte")).Count();
        return (latteCount*5000) + ((order.Length-latteCount)*4500);
    }
}