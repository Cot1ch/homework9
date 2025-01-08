namespace Tumakov9
{
    internal class Point : Figure
    {
        #region Constructors
        public Point(double x, double y, Colors color, EVisibility visibility) 
        {
            Color = color;
            Visibility = visibility;
            X = x;
            Y = y;
        }
        public Point(Colors color, EVisibility visibility) 
        {
            Color = color;
            Visibility = visibility;
            X = 0;
            Y = 0;
        }
        public Point() 
        { }
        #endregion
    }
}
