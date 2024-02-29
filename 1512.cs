public class Solution
{
    int choice = 0;
    public int NumIdenticalPairs(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i < j)
                {
                    if (nums[i] == nums[j])
                    {
                        choice += 1;
                    }
                }
            }
        }
        return choice;
    }
}
