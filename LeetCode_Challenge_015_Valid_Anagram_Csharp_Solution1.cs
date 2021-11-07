            bool ValidAnagram(string s, string t)
            {
                if(s.Length != t.Length)
                {
                    return false;
                }
                else
                {
                    char[] sArray = s.ToCharArray();
                    char[] tArray = t.ToCharArray();
                    Array.Sort(sArray);
                    Array.Sort(tArray);
                    int i = 0;
                    while ( i < tArray.Length && (sArray[i] == tArray[i]) )
                    {
                        i++;
                    }
                    if (i == tArray.Length)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            Console.WriteLine(ValidAnagram("anagram", "nagaram"));
            Console.WriteLine(ValidAnagram("oy", "y"));