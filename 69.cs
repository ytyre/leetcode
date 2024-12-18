public class Solution {
    public int MySqrt(int x) {
        double result = Math.Sqrt(x);
        return Convert.ToInt32(Math.Floor(result));
    }
}
