public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] list = new int[2];

        for(int i=0; i<nums.Length; i++){
            for(int j=0; j<nums.Length; j++){
                if(i!=j){ 
                    if (nums[i]+nums[j]==target){
                      list[0]=i;
                      list[1]=j;
                    }
                }
            }
        } 
       return list;
    }
}
