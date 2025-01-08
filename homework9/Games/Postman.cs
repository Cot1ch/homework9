using System;


namespace homework9
{
    internal class Postman : IGame
    {
        #region Field
        private string _Name = "Почтальоны";
        #endregion

        #region Properties
        public string Name
        {
            get { return _Name; }
        }
        #endregion

        #region Method
        public void LogDescription()
        {
            Console.WriteLine("///Тут должно было быть описание игры\n///Но его тут нет...");
        }
        #endregion
    }
}
