public class Solution {
    public int FindMiddleIndex(int[] nums) {
    var totalSum = nums.Sum();
    var leftSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            totalSum -= nums[i];

            if (totalSum == leftSum)
            {
                return i;
            }
            leftSum += nums[i];
        }
    return -1;
    }
}