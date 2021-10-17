public class Solution {
    public int RemoveDuplicates(int[] nums) 
 {
  int k = nums.Length;
  for(int i = 0; i < (nums.Length-1); i++)
  {
    if(nums[i] == nums[i+1]) 
    {
      k--;
      nums[i] = nums[nums.Length-1]+1;
    }
  }
  Array.Sort(nums);
  return k;
 }
}