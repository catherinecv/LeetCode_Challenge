            int FirstUniqueCharInString(string s) // Finds the first non-repeating character in a string and returns its index
            {
                char[] sArray = s.ToCharArray();

                if (sArray.Length == 1) // If there is only one letter, it is automatically the first non-repeating character
                {
                    return 0;
                }
                else
                {
                    int baseLetter = 0;
                    int comparedLetter;

                    while (baseLetter < sArray.Length) // Loop moving from one baseletter to the other until all have been checked
                    {
                        int cpt = 0;
                        comparedLetter = ((baseLetter+1)%sArray.Length);
                        while ( (cpt < (sArray.Length-1)) && (sArray[baseLetter] != sArray[comparedLetter]) )  // Loop comparing one baseletter to all other letters until a match is found
                        {
                            comparedLetter = ((comparedLetter + 1)%sArray.Length);
                            cpt++;
                        }

                        if (cpt == (sArray.Length-1)) // If the counter has reached its maximum, it means that no comparedletter matched the baseletter, meaning the baseletter is the first non-repeating character
                        {
                            return baseLetter;
                        }
                        else // Moves to next baseletter (if the counter has not reached its maximum, it means that a repeating letter was found)
                        {
                        baseLetter++;
                        }
                    }
                    return -1;
                }
            }
            //Test cases
            string word = "loveleetcode";  //should print 2
            Console.WriteLine(FirstUniqueCharInString(word));
            string word2 = "ddcca"; //should print 4
            Console.WriteLine(FirstUniqueCharInString(word2));