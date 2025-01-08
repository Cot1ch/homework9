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
            char[] enAlf = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string retstr = String.Empty;

            foreach (char c in s)
            {
                if (enAlf.Contains(c))
                {
                    retstr += enAlf[(Array.IndexOf(enAlf, c) + 1) % 26];
                }
                else if (cyrAlf.Contains(c))
                {
                    retstr += cyrAlf[(Array.IndexOf(cyrAlf, c) + 1) % 33];
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
            char[] enAlf = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string retstr = String.Empty;

            foreach (char c in s)
            {
                if (enAlf.Contains(c))
                {
                    if (c != 'a')
                    {
                        retstr += enAlf[(Array.IndexOf(enAlf, c) - 1) % 26];
                    }
                    else
                    {
                        retstr += "z";
                    }
                }
                else if (cyrAlf.Contains(c))
                {
                    if (c != 'а')
                    {
                        retstr += cyrAlf[(Array.IndexOf(cyrAlf, c) - 1) % 33];
                    }
                    else
                    {
                        retstr += "я";
                    }
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
