public class Solution {
    public int MajorityElement(int[] nums) {
        var dict = new Dictionary<int, int>();
        foreach(var item in nums)
        {
            if(dict.ContainsKey(item)) dict[item]++;
            else dict.Add(item, 1);
        }
        int result = dict.First(x => x.Value ==  dict.Values.Max()).Key;
        return result;
    }
}
