public class Solution {
    public int LengthOfLastWord(string s) {
        int count = 0;
        string str = s.Trim();
        for(int i = str.Length; i>0; i--){
            if(str[i-1]!=' '){
                count+=1;
            }
            if(str[i-1]==' '){
                break;
            }
        }
        return count;
    }
}
