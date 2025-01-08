using System;


namespace homework9
{
    internal class Fishing : IGame
    {
        #region Field
        private string _Name = "Рыбалка";
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
