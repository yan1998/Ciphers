using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeistelCipher
{
    enum Language {Russian=36,English }

    class Feistel
    {
        enum Mode { Plus, Minus }
        private string key1;
        private string key2;
        private Language language;
        private ToPDF pdf = new ToPDF();

        public Feistel(string key1,string key2,Language language,ToPDF pdf)
        {
            this.key1 = key1;
            this.key2 = key2;
            this.language = language;
            this.pdf = pdf;
        }

        //Определение оптимального размера блока
        public static List<int> BlockSizePropose(string[] arr)
        {
            //НАходится минимальная строка размером размером не менее 4 символов
            int size = (from str in arr
                       where str.Length>=4
                       orderby str.Length
                       select str.Length).First();
            Dictionary<int, int> sizes=new Dictionary<int, int>();
            for (int i = size / 2; i >= 2; i--)
                sizes[i] = size % i;
            //Поиск блока с целью наименьшего добавления лишних символов к строке
            List<int> result = (from s in sizes.Keys
                                where sizes[s]<2 && s%2==0
                                orderby sizes[s]
                                select s).ToList();
            return result;
        }

        //Шифрование входной строки
        public string Coder(string str)
        {
            //деление блока на две равные половины
            string l0 = str.Substring(0, key1.Length),
                r0=str.Substring(key1.Length,key1.Length);
            string temp1 = Table(r0, key1,Mode.Plus);
            string temp2 = Table(l0, temp1, Mode.Plus);
            string temp3 = Table(temp2, key2, Mode.Plus);
            string temp4 = Table(r0, temp3, Mode.Plus);
            return temp2+temp4;
        }

        //Метод для дешифрования 
        public string Decoder(string str)
        {
            //деление блока на две равные половины
            string l1 = str.Substring(0, key1.Length),
                r1 = str.Substring(key1.Length, key1.Length);
            string temp1 = Table(l1, key2,Mode.Plus);
            string temp2 = Table(r1,temp1,Mode.Minus);
            string temp3 = Table(temp2, key1,Mode.Plus);
            string temp4 = Table(l1, temp3,Mode.Minus);
            return temp4 + temp2;
        }

        //Реализация таблицы
        private string Table(string str1,string str2,Mode m)
        {
            string result = String.Empty;
            DataTable dataTable = new DataTable(str1+"   "+str2);
            dataTable.Columns.Add();
            dataTable.Columns.Add();
            dataTable.Columns.Add();
            dataTable.Columns.Add();
            dataTable.Columns.Add();
            dataTable.Columns.Add();
            for (int i = 0; i < str1.Length; i++)
            {
                int str1CharDigit = ConvertToDigit(str1[i]),
                    str2CharDigit=ConvertToDigit(str2[i]);
                int res;
                if (m == Mode.Plus)
                    res = (str1CharDigit + str2CharDigit) % (int)language;
                else
                {
                    res = str1CharDigit - str2CharDigit;
                    if (res < 0)
                        res += 36;
                }
                char resultSymbol = ConvertToChar(res);
                dataTable.Rows.Add(str1[i],str2[i],str1CharDigit,str2CharDigit,res,resultSymbol);
                result += resultSymbol;
            }
            pdf.AddTable(dataTable);
            return result;
        }

        //Преобразование символа в числовое значение
        private int ConvertToDigit(char ch)
        {
            int digit=-1;
            if (language == Language.Russian)
                if (Char.IsLetter(ch) && ch>='a' && ch<='е')
                    digit = (int)Char.ToLower(ch) - 1072;
                else if(Char.IsLetter(ch) && ch >= 'ж' && ch <= 'я')
                    digit = (int)Char.ToLower(ch) - 1071;
                else if (ch == 'ё')
                    digit = 6;
                else
                    switch (ch)
                    {
                        case '.': digit = 33; break;
                        case ',': digit = 34; break;
                        case ' ': digit = 35; break;
                        default: throw new Exception("Введён некорректный символ!");
                    }
            return digit;
        }

        //кодировка числа алфавита в символ
        private char ConvertToChar(int x)
        {
            char ch = '\n';
            if (language == Language.Russian)
                if (x >= 0 && x <= 5)
                    ch = (char)(x + 1072);
                else if (x >= 7 && x <= 32)
                    ch = (char)(x + 1071);
                else
                    switch (x)
                    {
                        case 33: ch = '.'; break;
                        case 34: ch = ','; break;
                        case 35: ch = ' '; break;
                        case 6: ch = 'ё'; break;
                        default: throw new Exception("Неверное число!!");
                    }
            return ch;
        }

    }
}
