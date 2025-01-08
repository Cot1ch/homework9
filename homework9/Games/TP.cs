using System;


namespace homework9
{
    internal class TP : IGame
    {
        #region Field
        private string _Name = "Весёлые старты";
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
            Console.WriteLine("///Успеть на физру к 8\n///Успеть с этой физры на пары к 10");
        }
        #endregion
    }
}
