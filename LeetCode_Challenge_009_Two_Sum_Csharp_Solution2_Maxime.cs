            int[] TwoSum(int[] nums, int target)
            {
                int[] indices = new int[2];
                for (int i = 0; i < nums.Length-1; i++)
                {
                    for (int j = i+1; j < nums.Length; j++)
                    {
                        if (target-nums[i]-nums[j] == 0)
                        {
                            indices[0] = i;            
                            indices[1] = j;
                        }
                    }
                }   
                return indices;
            }