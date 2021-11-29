    bool IsValidSudoku(char[][] board) {
        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[i].Length; j++) {
                if ( Char.IsDigit(board[i][j]) )
                {
                    
                    for (int k = j+1; k < board[i].Length; k++) {
                        if (board[i][k%9] == board[i][j]) {
                            return false;
                        }
                    }
                    
                    for (int m = i+1; m < board.Length; m++) {
                    if (board[m%9][j] == board[i][j]) {
                            return false;
                        }
                    }

                    int ligneDepart = i - i%3;
                    int colonneDepart = j - j%3;

                    for (int l = ligneDepart; l < ligneDepart + 3; l++) {
                        for (int c = colonneDepart; c < colonneDepart+3; c++) {
                            if (board[l][c] == board[i][j]) {
                                if (i == l && j == c)
                                {c++;}
                                else
                                {return false;}
                            }
                        }
                    }

                }
            }
        }
        return true;
    }

    // **************************************************************************

    char[][] board1 = {
        new char[]{'.','.','.','.','.','.','.','.','.'},
        new char[]{'6','.','9','.','.','8','.','.','.'},
        new char[]{'.','.','.','4','.','6','.','.','.'},
        new char[]{'.','.','.','.','.','.','.','1','.'},
        new char[]{'.','.','.','.','2','.','.','3','.'},
        new char[]{'.','4','.','.','.','.','.','.','4'},
        new char[]{'5','.','.','6','.','.','.','.','.'},
        new char[]{'.','.','.','.','.','.','.','.','.'},
        new char[]{'.','.','.','.','7','.','6','.','.'}};

    foreach (char[] tableau in board1)
        {
            foreach (char element in tableau)
            {
                Console.Write(element + "  ");
            }
            Console.WriteLine();
        }

    Console.WriteLine(IsValidSudoku(board1));
    