         int ReverseInteger(int x)
            {
                int nombre = x;  // eg -123

                if (x < 0)
                {
                nombre = -nombre;  // 123
                }

                int resultat = 0;
                int chiffre = 0;

                while (nombre > 0)
                {
                    chiffre = nombre%10;  // units = 123%10 = 3
                    resultat = resultat + chiffre;  // result = 0+3 = 3
                    nombre = nombre - chiffre;  // number = 123-3 = 120
                    if (nombre > 0)
                    {
                        nombre = nombre/10;  // 120/10 = 12
                        if (resultat > Math.Pow(2,31)/10)  //checks signed 32-bit integer range
                        {
                            return 0;
                        }
                        resultat = resultat*10;  // result = 3*10 = 30
                    }  
                }

                if (x < 0)
                {
                    resultat = -resultat;
                }
                    
                return resultat;
            }

            int reponse = ReverseInteger(-123);
            Console.WriteLine(reponse);