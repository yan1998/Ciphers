using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class Squares
    {
        char[,] square1 = new char[5, 5];
        char[,] square2 = new char[5, 5];
        char[,] square3 = new char[5, 5];
        char[,] square4 = new char[5, 5];

        public Squares()
        {
            #region Square1

            square1[0, 0] = 'K';
            square1[0, 1] = 'I';
            square1[0, 2] = 'N';
            square1[0, 3] = 'G';
            square1[0, 4] = 'D';
            square1[1, 0] = 'O';
            square1[1, 1] = 'M';
            square1[1, 2] = 'A';
            square1[1, 3] = 'B';
            square1[1, 4] = 'C';
            square1[2, 0] = 'E';
            square1[2, 1] = 'F';
            square1[2, 2] = 'H';
            square1[2, 3] = 'L';
            square1[2, 4] = 'P';
            square1[3, 0] = 'Q';
            square1[3, 1] = 'R';
            square1[3, 2] = 'S';
            square1[3, 3] = 'T';
            square1[3, 4] = 'U';
            square1[4, 0] = 'V';
            square1[4, 1] = 'W';
            square1[4, 2] = 'X';
            square1[4, 3] = 'Y';
            square1[4, 4] = 'Z';

            #endregion

            #region Square2

            square2[0, 0] = 'V';
            square2[0, 1] = 'Q';
            square2[0, 2] = 'E';
            square2[0, 3] = 'O';
            square2[0, 4] = 'K';
            square2[1, 0] = 'W';
            square2[1, 1] = 'R';
            square2[1, 2] = 'F';
            square2[1, 3] = 'M';
            square2[1, 4] = 'I';
            square2[2, 0] = 'X';
            square2[2, 1] = 'S';
            square2[2, 2] = 'H';
            square2[2, 3] = 'A';
            square2[2, 4] = 'N';
            square2[3, 0] = 'Y';
            square2[3, 1] = 'T';
            square2[3, 2] = 'L';
            square2[3, 3] = 'B';
            square2[3, 4] = 'G';
            square2[4, 0] = 'Z';
            square2[4, 1] = 'U';
            square2[4, 2] = 'P';
            square2[4, 3] = 'C';
            square2[4, 4] = 'D';

            #endregion

            #region Square3

            square3[0, 0] = 'Z';
            square3[0, 1] = 'Y';
            square3[0, 2] = 'X';
            square3[0, 3] = 'W';
            square3[0, 4] = 'V';
            square3[1, 0] = 'U';
            square3[1, 1] = 'T';
            square3[1, 2] = 'S';
            square3[1, 3] = 'R';
            square3[1, 4] = 'Q';
            square3[2, 0] = 'P';
            square3[2, 1] = 'L';
            square3[2, 2] = 'H';
            square3[2, 3] = 'F';
            square3[2, 4] = 'E';
            square3[3, 0] = 'C';
            square3[3, 1] = 'B';
            square3[3, 2] = 'A';
            square3[3, 3] = 'M';
            square3[3, 4] = 'O';
            square3[4, 0] = 'D';
            square3[4, 1] = 'G';
            square3[4, 2] = 'N';
            square3[4, 3] = 'I';
            square3[4, 4] = 'K';

            #endregion

            #region Square4

            square4[0, 0] = 'K';
            square4[0, 1] = 'O';
            square4[0, 2] = 'E';
            square4[0, 3] = 'Q';
            square4[0, 4] = 'V';
            square4[1, 0] = 'I';
            square4[1, 1] = 'M';
            square4[1, 2] = 'F';
            square4[1, 3] = 'R';
            square4[1, 4] = 'W';
            square4[2, 0] = 'N';
            square4[2, 1] = 'A';
            square4[2, 2] = 'H';
            square4[2, 3] = 'S';
            square4[2, 4] = 'X';
            square4[3, 0] = 'G';
            square4[3, 1] = 'B';
            square4[3, 2] = 'L';
            square4[3, 3] = 'T';
            square4[3, 4] = 'Y';
            square4[4, 0] = 'D';
            square4[4, 1] = 'C';
            square4[4, 2] = 'P';
            square4[4, 3] = 'U';
            square4[4, 4] = 'Z';

            #endregion
        }

        public string EncodeToSquaresCipher(string word)
        {
            string result = String.Empty;
            byte b = 1;
            foreach (var sybmol in word)
            {
                if (!Char.IsLetter(sybmol) || sybmol == 'J')
                    result += sybmol;
                else
                    result += GetCharToSquareCipher(sybmol, b);
                if (b == 1)
                    b++;
                else if (b == 2)
                    b--;
            }
            return result;
        }

        public string DecodeFromSquaresCipher(string word)
        {
            string result = String.Empty;
            byte b = 3;
            foreach (var sybmol in word)
            {
                if (!Char.IsLetter(sybmol) || sybmol=='J')
                    result += sybmol;
                else
                    result += GetCharToSquareCipher(sybmol, b);
                if (b == 3)
                    b++;
                else if (b == 4)
                    b--;
            }
            return result;
        }

        public char GetCharToSquareCipher(char symbol,byte square)
        {
            char newSymbol=' ';
            if (square == 1)
            {
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                        if (square1[i, j] == symbol)
                            return square3[i, j];
            }
            else if (square == 2)
            {
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                        if (square2[i, j] == symbol)
                            return square4[i, j];
            }
            else if (square == 3)
            {
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                        if (square3[i, j] == symbol)
                            return square1[i, j];
            }
            else if (square == 4)
            {
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                        if (square4[i, j] == symbol)
                            return square2[i, j];
            }
            return newSymbol;
        }

        public override string ToString()
        {
            string temp1 = "", temp2="", temp3="", temp4="";
            for (int i=0; i<5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    temp1 += square1[i, j].ToString() + '\t';
                    temp2 += square2[i, j].ToString() + '\t';
                    temp3 += square3[i, j].ToString() + '\t';
                    temp4 += square4[i, j].ToString() + '\t';
                }
                temp1 += '\n';
                temp2 += '\n';
                temp3 += '\n';
                temp4 += '\n';
            }
            return temp1+'\n' + temp2 + '\n' + temp3 + '\n' + temp4 ;
        }
    }
}
