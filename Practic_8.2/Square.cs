namespace Practic_8._2
{
    internal class Square : Parallelogram
    {
        #region methods
        public Square(float side1) : base(side1) { }

        public override float GetArea()
        {
            return Side1 * Side1;
        }

        public override string ToString()
        {
            return $"Квадрат, довжина строни: {Side1}";
        }
        #endregion
    }
}
