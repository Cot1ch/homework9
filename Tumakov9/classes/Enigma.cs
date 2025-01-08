namespace Tumakov9
{
    static class Enigma
    {
        #region Methods

        /// <summary>
        /// Метод возвращает строку, расшифрованную одним из методов ICipher
        /// </summary>
        /// <returns><Строка string/returns>
        public static string Dec(ICipher cipher, string str)
        {
            return cipher.Decode(str);
        }

        /// <summary>
        /// Метод возвращает строку, зашифрованную одним из методов ICipher
        /// </summary>
        /// <returns><Строка string/returns>
        public static string Enc(ICipher cipher, string str)
        {
            return cipher.Encode(str);
        }

        #endregion
    }
}