public class Solution {
    public int[] PlusOne(int[] digits) {
        string str = string.Join("", digits); 
        BigInteger number = BigInteger.Parse(str) + 1; 
        str = number.ToString();
        int[] list = new int[str.Length];
        for (int i = 0; i < str.Length; i++) {
            list[i] = Int32.Parse(str[i].ToString());
        }
        return list;
    }
}
