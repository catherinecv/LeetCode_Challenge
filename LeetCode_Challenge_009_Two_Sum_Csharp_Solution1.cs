            int[] TwoSum(int[] nums, int target)
            {
                int[] indices = new int[2];
                int i = 0;
                int j = 0;
                int z = 0;
                int sum;
                do
                {
                    j = i+1;
                    do
                    {
                        sum = nums[i]+nums[j];
                        j++;
                    } while (j < nums.Length && sum != target);
                    z = j-1;
                    i++;
                } while (i < nums.Length-1 && sum != target);
                indices[0] = i-1;            
                indices[1] = z;
                return indices;
            }