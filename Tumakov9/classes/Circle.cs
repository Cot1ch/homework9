using System;

namespace Tumakov9
{
    internal class Circle : Point
    {
        #region Field

        double _Rad;

        #endregion

        #region Constructor

        public Circle(double rad) : base()
        {
            _Rad = rad;
        }

        #endregion

        #region Method

        /// <summary>
        /// Метод возвращает площадь круга
        /// </summary>
        /// <returns>Число типа double</returns>
        public double GetPl()
        {
            return _Rad * _Rad * Math.PI;
        }

        public override string ToString() 
        {
            return $"Радиус = {_Rad}\n" + base.ToString();
        }
        #endregion
    }
}
