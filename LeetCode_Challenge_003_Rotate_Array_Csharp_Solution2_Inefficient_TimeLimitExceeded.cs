public class Solution {
    public void Rotate(int[] nums, int k) {
for(int b = 0; b < k; b++)
  {
    int temporary = nums[nums.Length-1]; 
    for(int i = (nums.Length-1); i > 0; i--)
    {
      nums[i] = nums[i-1];
    }
    nums[0] = temporary;
  }
}
}