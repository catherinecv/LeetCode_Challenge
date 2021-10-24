
        int[] PlusOne(int[] digits)
            {
                if (digits[digits.Length-1] == 9 && digits[0] == 9) //last digit is 9 and first digit is 9, e.g. 9 or 94499
                {                
                    int z = digits.Length-1; //checking if all digits are 9s
                    while(z >= 0 && digits[z] == 9)
                    {
                        z--;
                    }
                    if(z == -1) //z reached -1 because all digits are 9s
                    {
                        int[] modifiedDigits = new int[digits.Length+1];
                        modifiedDigits[0] = 1;
                        int i = 1;
                        while(i < modifiedDigits.Length)
                        {
                            modifiedDigits[i] = 0;
                            i++;
                        }
                        return modifiedDigits;
                    }
                    else //starting from the end of the array, z stopped at the first digit that is not a 9
                    {
                        digits[z]++;
                        while (z+1 < digits.Length)
                        {
                            digits[z+1] = 0;
                            z++;
                        }
                        return digits;
                    }
                }
                else if (digits[digits.Length-1] == 9 && digits[0] != 9) //last digit is 9 and first digit is not 9, e.g. 4499
                {
                    int b = 0;
                    while ((digits.Length-1-b) >= 0 && digits[digits.Length-1-b] == 9) //changes 9s to 0s
                    {
                        digits[digits.Length-1-b] = 0;
                        b++;
                    } 
                    digits[digits.Length-1-b]++;
                    return digits;
                }
                else //last digit is not 9, e.g. 8 or 98
                {
                    digits[digits.Length-1]++;
                    return digits;
                }
            }
