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
                    for (int i = 0; i < tArray.Length; i++)
                    {
                        if (sArray[i] != tArray[i])
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }

            Console.WriteLine(ValidAnagram("anagram", "nagaram"));
            Console.WriteLine(ValidAnagram("oy", "y"));