using System.Collections.Generic;

int[] Intersect(int[] nums1, int[] nums2) 
{
  Array.Sort(nums1);
  Array.Sort(nums2);
  int nextStart = 0;
  List<int> result = new List<int>(); //Nouveau
  if (nums1.Length <= nums2.Length)
  {
    for(int i = 0; i < nums1.Length; i++)
    {
      int b = nextStart;
      while (b < nums2.Length && nums1[i] != nums2[b])
      {b++;}
      if (b < nums2.Length)
        {
        result.Add(nums2[b]); //Nouveau
        nextStart = b+1;
        }
    }
  }
  else //nums1.Length > nums2.Length
  {
    for(int i = 0; i < nums2.Length; i++)
    {
      int b = nextStart;
      while (b < nums1.Length && nums2[i] != nums1[b])
      {b++;}
      if (b < nums1.Length)
        {
        result.Add(nums1[b]); //Nouveau
        nextStart = b+1;
        }
    }
  }
  int[] arrayResult = result.ToArray();
  return arrayResult;
}