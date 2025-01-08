using System;


namespace homework9
{
    internal class Country
    {
        #region Fields
        private string _Name;
        private Person[] _Players; // Запасных не будет
        private int _Place;
        #endregion

        #region Constructors
        public Country(string name, Person[] players)
        {
            _Name = name;
            _Players = players;
        }
        public Country(string name)
        { 
            _Name = name;
            _Players = new Person[15];

        }
        public Country()
        {
            _Players = new Person[15];
        }
        #endregion

        #region Properties
        public int Place
        {
            get { return _Place; }
            set { _Place = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        #endregion

        #region Method

        /// <summary>
        /// Метод добавления состава команды
        /// </summary>
        public void AddPlayers()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.Write($"{i + 1}: ");
                _Players[i] = new Person(Console.ReadLine());
            }
            Console.WriteLine("Игроки добавлены");
        }
        #endregion
    }
}
