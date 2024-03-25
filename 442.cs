public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        Array.Sort(nums);
        int zero = 0;
        int[] nums2 = new int[nums.Length];
        for(int i = 1; i<nums.Length; i++){
            if(nums[i]==nums[i-1]){
                nums2[zero]=nums[i];
                i += 1;
                zero++;
            }            
        }
        int[] nums3 = new int[zero];
        for(int i = 0; i<zero; i++){
            nums3[i]=nums2[i];
        }
        return nums3;
    }
}
