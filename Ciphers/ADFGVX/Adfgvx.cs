using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Cipher
{
    class Adfgvx
    {
        private Dictionary<char, Dictionary<char, char>> cipher;

        public Adfgvx()
        {
            cipher = new Dictionary<char, Dictionary<char, char>>();

            string str = "ADFGVX";
            StreamReader read = new StreamReader("cipher.txt");
            foreach (var symbol1 in str)
            {
                cipher[symbol1] = new Dictionary<char, char>();
                foreach (var symbol2 in str)
                    cipher[symbol1][symbol2] = read.ReadLine()[0];
            }
        }

        public string EncodeToAdfgvx(string word)
        {
            string result = String.Empty;
            bool end=false;
            foreach (var symbol in word)
            {
                if (!Char.IsLetterOrDigit(symbol) || symbol == 'J')
                {
                    result += symbol;
                    continue;
                }
                end = false;
                foreach (var horizontal in cipher.Keys)
                {
                   if (end) break;
                   foreach (var vertical in cipher[horizontal].Keys)
                        if (cipher[horizontal][vertical] == symbol)
                        {
                            result += horizontal.ToString() + vertical;
                            end = true;
                            break;
                        }
                }
            }
            return result;
        }

        public string DecodeFromAdfgvx(string word)
        {
            string result = String.Empty, temp=String.Empty;
            foreach (var symbol in word)
            {
                if (!Char.IsLetterOrDigit(symbol) || symbol=='J')
                {
                    result += symbol;
                    continue;
                }
                temp += symbol;
                if (temp.Length == 2)
                {
                    result += cipher[temp[0]][temp[1]];
                    temp = String.Empty;
                }
            }
            return result;
        }

        public override string ToString()
        {
            string temp = String.Empty;
            temp += " \t" + "A\t" + "D\t" + "F\t" + "G\t" + "V\t" + "X\n";
            foreach (var h in cipher.Keys)
            {
                temp += h.ToString().ToUpper() + '\t';
                foreach (var v in cipher[h].Values)
                    temp += v.ToString().ToUpper() + '\t';
                temp += '\n';
            }
            return temp;
        }

        public bool CheckCipher()
        {
            bool b = true;
            Dictionary<char, bool> d = new Dictionary<char, bool>();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                if (i == 'J')
                    d[i] = true;
                else
                    d[i] = false;
            }

            foreach (var horizontal in cipher.Keys)
            {
                foreach (var vertical in cipher[horizontal].Keys)
                    d[cipher[horizontal][vertical]] = true;
            }
            foreach (var item in d.Values)
            {
                if (!item)
                {
                    b = false;
                    break;
                }
            }
            return b;
        }

    }
}
