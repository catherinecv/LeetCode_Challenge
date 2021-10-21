public class Solution {
  public bool ContainsDuplicates(int[] nums)
{
  Array.Sort(nums);
  int i = 0;
  while (i < nums.Length-1 && nums[i] != nums[i+1])
  { 
   i++;
  }
  if (i == nums.Length-1)
   {return false;}
  else
   {return true;}
}
}