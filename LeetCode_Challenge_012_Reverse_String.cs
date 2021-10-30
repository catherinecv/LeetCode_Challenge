            Console.WriteLine("SOLUTION #1");

            char[] ReverseString(char[] s)   //Fonction
            {
                char[] newS = new char[s.Length];
                for(int i = 0; i < s.Length; i++)
                {
                    newS[i] = s[s.Length-1-i];
                }
                
                for(int b = 0; b < s.Length; b++)
                {
                    s[b] = newS[b];
                }
                return s;
            }

            char[] mot = {'S','a','l','u','t'};  //Test
            ReverseString(mot);
            for(int b = 0; b < mot.Length; b++)
            {
                Console.Write(mot[b] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("SOLUTION #2");

            void ReverseTheString(char[] s)  //Fonction
            {
                Array.Reverse(s);
            }
            
            char[] mot2 = {'H','e','y','Y','a'};  //Test
            ReverseTheString(mot2);
            for(int c = 0; c < mot2.Length; c++)
            {
                Console.Write(mot2[c] + " ");
            }
