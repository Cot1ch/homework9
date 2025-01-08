using System;
using System.CodeDom;
using System.Collections.Generic;

namespace homework9
{ 
    internal class Boss : Person
    {
        #region Fields
        private string _Name;
        private List<IGame> Games;
        private Dictionary<Country, List<int>> _Countries;
        #endregion

        #region Constructor
        public Boss(string name) : base(name)
        {
            Games = new List<IGame>();
            _Countries = new Dictionary<Country, List<int>>();
        }
        #endregion

        #region Properties
        public Dictionary<Country, List<int>> Countries
        {
            get { return _Countries; }
            set { _Countries = value; }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Метод добавляет игру в общий список, если такой игры нет
        /// </summary>
        /// <returns>Булево значение</returns>
        public bool AddGame(IGame game)
        {
            if (!Games.Contains(game))
            {
                Games.Add(game);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Метод добавляет страну в общий список, если такой страны нет
        /// </summary>
        /// <returns>Булево значение</returns>
        public bool AddCountry(Country country)
        {
            if (Countries.ContainsKey(country))
            {
                return false;
            }
            Countries[country] = new List<int>();
            return true;
        }

        /// <summary>
        /// Метод выбирает 6 случайных игр из общего списка
        /// </summary>
        /// <returns>Коллекция IGame</returns>
        public List<IGame> ChooseGames()
        {
            if (Games.Count >= 6)
            {
                List<IGame> list = new List<IGame>();

                while (list.Count != 6)
                {
                    int rndInd = new Random().Next(Games.Count);
                    if (!list.Contains(Games[rndInd]))
                    {
                        list.Add(Games[rndInd]);
                    }
                }
                return list;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Метод выводит информацию о каждой игре из общего списка
        /// </summary>
        public void LogAllGames()
        {
            foreach (IGame game in Games)
            {
                Console.WriteLine(game.Name);
            }
        }
        #endregion
    }
}
