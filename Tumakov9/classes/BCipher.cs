using System;
using System.Linq;


namespace Tumakov9
{
    internal class BCipher : ICipher
    {
        #region Methods

        /// <summary>
        /// Метод зашифровывает переданную строку, заменяя i-ый элемент алфавита на i-ый с конца алфавита. 
        /// Поддерживаются кириллица и латиница
        /// </summary>
        /// <returns>Строка string</returns>
        public string Encode(string s)
        {
            char[] cyrAlf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            char[] cyrUpperAlf = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
            char[] enAlf = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] enUpperAlf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string retstr = String.Empty;

            foreach (char c in s)
            {
                if (enAlf.Contains(c))
                {
                    retstr += enAlf[25 - Array.IndexOf(enAlf, c)];
                }
                else if (enUpperAlf.Contains(c))
                {
                    retstr += enUpperAlf[25 - Array.IndexOf(enUpperAlf, c)];
                }
                else if (cyrAlf.Contains(c))
                {
                    retstr += cyrAlf[32 - Array.IndexOf(cyrAlf, c)];
                }
                else if (cyrUpperAlf.Contains(c))
                {
                    retstr += cyrUpperAlf[32 - Array.IndexOf(cyrUpperAlf, c)];
                }
                else
                {
                    retstr += c;
                }
            }

            return retstr;
        }

        /// <summary>
        /// Метод расшифровывает переданную строку, заменяя i-ый элемент алфавита на i-ый с конца алфавита. 
        /// Поддерживаются кириллица и латиница
        /// </summary>
        /// <returns>Строка string</returns>
        public string Decode(string s)
        {
            return Encode(s); // Они одинаковы))
        }

        #endregion
    }
}
