using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeistelCipher
{
   public static class ExtensionString
   {
        public static string Reverse(this String str)
        {
            string str2 = "";
            for (int i = str.Length - 1; i >= 0; i--)
                str2 += str[i];
            return str2;
        }
   }
}
