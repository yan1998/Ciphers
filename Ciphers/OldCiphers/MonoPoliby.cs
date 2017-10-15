using System;
using System.Collections.Generic;

namespace OldCodes
{
    class MonoPoliby
    {
        private Dictionary<char, char> monoCipher = new Dictionary<char, char>();
        private char[,] polibySquare = new char[5, 5];

        public MonoPoliby()
        {
            monoCipher.Add('a', '(');
            monoCipher.Add('b', ')');
            monoCipher.Add('c', '[');
            monoCipher.Add('d', ']');
            monoCipher.Add('e', '{');
            monoCipher.Add('f', '}');
            monoCipher.Add('g', '-');
            monoCipher.Add('h', '=');
            monoCipher.Add('i', '*');
            monoCipher.Add('k', '+');
            monoCipher.Add('l', '<');
            monoCipher.Add('m', '>');
            monoCipher.Add('n', '?');
            monoCipher.Add('o', '.');
            monoCipher.Add('p', ',');
            monoCipher.Add('q', '/');
            monoCipher.Add('r', '|');
            monoCipher.Add('s', '!');
            monoCipher.Add('t', '@');
            monoCipher.Add('u', '$');
            monoCipher.Add('v', '%');
            monoCipher.Add('w', '&');
            monoCipher.Add('x', '^');
            monoCipher.Add('y', '`');
            monoCipher.Add('z', '\'');
            createPolibySquare();
        }

        /*
         * Запись моноалфавитного шифра в квадрат Полибия 
         */
        private void createPolibySquare()
        {
            int i = 0, j = 0;
            foreach (var value in monoCipher.Values)
            {
                if (j == 5)
                {
                    j = 0;
                    i++;
                }
                polibySquare[i, j] = value;
                j++;
            }
        }

        /*
         * Метод кодирующий входную строку в моноалфавитный шифр
         */
        public string encodeToMonoCipher(string word)
        {
            word = word.Replace('j', 'i');
            string result = String.Empty;
            foreach (char letter in word)
                if(Char.IsLetter(letter))
                    result += monoCipher[letter];
            return result;
        }

        /*
         * Метод декодирующий входную строку из моноалфавитного шифра
         * в англоязычную строку
         */
        public string decodeFromMonoCipher(string code)
        {
            string result = String.Empty;
            foreach (var symbol in code)
                foreach (var key in monoCipher.Keys)
                    if (monoCipher[key] == symbol)
                        result += key;
            return result;
        }

        /*
         * Кодирование из моношифра в шифр Полибия
         */
        public string encodeToPoliby(string monoCode)
        {
            string result = String.Empty;
            string temp = String.Empty;
            foreach (var symbol in monoCode)
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                        if (polibySquare[i, j] == symbol)
                        {
                            temp += i.ToString() + j;
                            break;
                        }   
            string t1 = String.Empty,t2=String.Empty;
            for (int i = 0; i < temp.Length; i++)
                if (i % 2 == 0)
                    t1 += temp[i];
                else
                    t2 += temp[i];
            temp = t1 + t2;
            for (int i = 0; i < temp.Length; i+=2)
                result += polibySquare[int.Parse(temp[i].ToString()), int.Parse(temp[i+1].ToString())];
            return result;
        }

        /*
         * Декодирование из шифра Полибия в моношифр
         */
        public string decodeFromPoliby(string polibyCode)
        {
            string temp=String.Empty,result = String.Empty;
            foreach (var symbol in polibyCode)
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                        if (polibySquare[i, j] == symbol)
                        {
                            temp += i.ToString() + j;
                            break;
                        }
            for (int i = 0; i < temp.Length / 2; i++)
                result +=polibySquare[int.Parse(temp[i].ToString()), int.Parse(temp[i + temp.Length / 2].ToString())];
            return result;
        }

        /*
        * Преобразования квадрата ПОлибия для моноалфавитного шрифта в строку
        */
        public string getPolibySquare()
        {
            string square = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    square += polibySquare[i, j].ToString() + "                ";
                }
                square += "\n\n";
            }
            return square;
        }
    }
}
