
    bool IsPalindrome(string s) {
         
                string lowerS = s.ToLower();
                
                int i = 0;
                int j = 0;

                while ( (i+j) < lowerS.Length)
                    {
                        while (i < lowerS.Length && !Char.IsLetterOrDigit(lowerS, i))
                        {
                            i++;
                        }
                        
                        while ( (j+i) < lowerS.Length && !Char.IsLetterOrDigit(lowerS, (lowerS.Length-1-j) ))
                        {
                            j++;
                        }

                        if (i == lowerS.Length)
                        {
                            return true;
                        }
                        else if ( (i+j) == lowerS.Length )
                        {
                            return true;
                        }
                        else if (lowerS[i] != lowerS[lowerS.Length-1-j])
                        {
                            return false;
                        }
                        else
                        {
                            i++;
                            j++;
                        }
                    }

                return true;
        
    }
