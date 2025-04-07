public class Solution {
    public int SingleNumber(int[] nums) {
        return nums.GroupBy(num => num)
           .First(group => group.Count() == 1)
           .Key;
    }
}
