using System;
using System.Linq;


namespace Tumakov9
{
    internal class ACipher : ICipher
    {
        #region Methods

        /// <summary>
        /// Метод зашифровывает переданную строку, заменяя на следующую за ней в алфавитном порядке. 
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
                    retstr += enAlf[(Array.IndexOf(enAlf, c) + 1) % 26];
                }
                else if (enUpperAlf.Contains(c))
                {
                    retstr += Char.ToUpper(enUpperAlf[(Array.IndexOf(enUpperAlf, c) + 1) % 26]);
                }
                else if (cyrAlf.Contains(c))
                {
                    retstr += cyrAlf[(Array.IndexOf(cyrAlf, c) + 1) % 33];
                }
                else if (cyrUpperAlf.Contains(c))
                {
                    retstr += Char.ToUpper(cyrUpperAlf[(Array.IndexOf(cyrUpperAlf, c) + 1) % 33]);
                }
                else
                {
                    retstr += c;
                }                
            }

            return retstr;
        }

        /// <summary>
        /// Метод расшифровывает переданную строку, заменяя букву на предыдущую в алфавитном порядке. 
        /// Поддерживаются кириллица и латиница
        /// </summary>
        /// <returns>Строка string</returns>
        public string Decode(string s)
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
                    retstr += enAlf[(Array.IndexOf(enAlf, c) + 25) % 26];
                }
                else if (enUpperAlf.Contains(c))
                {
                    retstr += Char.ToUpper(enUpperAlf[(Array.IndexOf(enUpperAlf, c) + 25) % 26]);
                }
                else if (cyrAlf.Contains(c))
                {
                    retstr += cyrAlf[(Array.IndexOf(cyrAlf, c) + 32) % 33];
                }
                else if (cyrUpperAlf.Contains(c))
                {
                    retstr += Char.ToUpper(cyrUpperAlf[(Array.IndexOf(cyrUpperAlf, c) + 32) % 33]);
                }
                else
                {
                    retstr += c;
                }
            }

            return retstr;
        }

        #endregion
    }
}
