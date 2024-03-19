public class Solution {
    public bool IsPalindrome(int x) {
       bool result = true;
        string fist = x.ToString();
        char[] list=new char[fist.Length];
        char[] list1 = new char[fist.Length];
        for (int i = 0; i<fist.Length ; i++)
        {
             list[i] = fist[i];
            list1[fist.Length - 1 - i] = fist[i];
        }
        for(int i = 0; i < fist.Length; i++)
        {
            if (list[i] != list1[i])
            {
                result = false; 
            }
        }
    return result;
    }
}
