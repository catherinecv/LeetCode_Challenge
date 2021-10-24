        int[] MoveZeroes (int[] nums)   
        {
            int count = 0;
            int i = 0;
            while(i < nums.Length-1-count)
            {
                if (nums[i] != 0)
                {
                    i++;
                }
                else //nums[i] == 0
                {
                    for(int j = i; j < nums.Length-1-count; j++)
                    {
                        int temporary;
                        temporary = nums[j+1];
                        nums[j+1] = nums[j];
                        nums[j] = temporary;
                    }
                count++;
                }
            }
            return nums;
        }