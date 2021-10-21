public class Solution {
    public int SingleNumber(int[] nums) {
  Array.Sort(nums);
  int i = 1;
  if (nums.Length == 1 || (nums[0] != nums[1]))
  {return nums[0];}
  else if (nums[nums.Length-1] != nums[nums.Length-2])
     {return nums[nums.Length-1];}
  else
     {
      while((i < (nums.Length-1)) && (nums[i] == nums[i-1] || nums[i] == nums[i+1]))
      {i++;}
      return nums[i];
     }
}
}