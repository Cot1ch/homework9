using System;

namespace Tumakov9
{
    internal abstract class Figure : IMove, IFigure
    {
        #region Fields

        Colors _Color;
        EVisibility _Visibility;
        double _X;
        double _Y;

        #endregion

        #region Constructor
        public Figure()
        {
            _Color = Colors.Белый;
            _Visibility = EVisibility.Visible;
            _X = 0;
            _Y = 0;
        }

        #endregion

        #region Properties

        public Colors Color
        {
            get { return _Color; }
            set { _Color = value; }
        }
        public EVisibility Visibility
        {
            get { return _Visibility; }
            set { _Visibility = value; }
        }
        public double X
        {
            get { return _X; }
            set { _X = value; }
        }
        public double Y
        {
            get { return _Y; }
            set { _Y = value; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Возвращает информацию о геометрической фигире
        /// </summary>
        /// <returns>Строка string</returns>
        public override string ToString()
        {
            string retStr = $"{this.GetType().Name}\nЦвет: {Color}\n{Visibility}\nПоложение: ({_X}, {_Y})\n";

            return retStr;
        }

        /// <summary>
        /// Выводит состояние фигуры
        /// </summary>
        public void ShowVisibility()
        {
            Console.WriteLine(Visibility);
        }

        /// <summary>
        /// Меняет цвет фигуры
        /// </summary>
        public void ChangeColor(Colors newColor)
        {
            _Color = newColor;
        }

        /// <summary>
        /// Метод изменяет положение фигуры на оси oY
        /// </summary>
        public void MoveVert(double dy)
        {
            _Y += dy;
        }

        /// <summary>
        /// Метод изменяет положение фигуры на оси oX
        /// </summary>
        public void MoveHor(double dx)
        {
            _X += dx;
        }

        /// <summary>
        /// Метод изменяет положение объекта на плоскости
        /// </summary>
        public void MoveEverywhere(double dx, double dy)
        {
            MoveHor(dx);
            MoveVert(dy);
        }
        #endregion
    }
}
