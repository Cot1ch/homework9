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
            string retstr = String.Empty;

            foreach (char c in s)
            {
                if ("qwertyuiopasdfghjklzxcvbnm".ToCharArray().Contains(c)) //Проверка на алфавит
                {
                    retstr += (char)(-(c - 'a') + 'z');
                }
                else if ("йцукенгшщзхъфывапролджэячсмитьбюё".ToCharArray().Contains(c))
                {
                    retstr += (char)(-(c - 'а') + 'я');
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
            string retstr = String.Empty;
            foreach (char c in s)
            {
                if ("qwertyuiopasdfghjklzxcvbnm".ToCharArray().Contains(c))
                {
                    retstr += (char)(-(c - 'a') + 'z');
                }
                else if ("йцукенгшщзхъфывапролджэячсмитьбюё".ToCharArray().Contains(c))
                {
                    retstr += (char)(-(c - 'а') + 'я');
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
