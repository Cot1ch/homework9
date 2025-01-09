namespace Tumakov9
{
    internal class Rectangle : Point
    {
        #region Fields

        double _ASide;
        double _BSide;

        #endregion

        #region Constructor

        public Rectangle(double aSide, double bSide) : base()
        {
            _ASide = aSide;
            _BSide = bSide;
        }

        #endregion

        #region Properties

        public double ASide
        {
            get { return _ASide; }
            set { _ASide = value; }
        }
        public double BSide
        {
            get { return _BSide; }
            set { _BSide = value; }
        }

        #endregion

        #region Method

        /// <summary>
        /// Метод возвращает площадь прямоугольника
        /// </summary>
        /// <returns>Число типа double</returns>
        public double GetPl()
        {
            return _ASide * _BSide;
        }

        public override string ToString()
        {
            return $"Размеры: {_ASide} x {_BSide}\n" + base.ToString();
        }
        #endregion
    }
}
