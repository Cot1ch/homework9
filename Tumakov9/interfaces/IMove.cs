namespace Tumakov9
{
    internal interface IMove
    {
        void MoveVert(double dy);
        void MoveHor(double dx);

        void MoveEverywhere(double dx, double dy);
    }
}
