namespace Practic_8._2
{
    internal class Rectangle : Parallelogram
    {
        #region fields
        private float _side2;

        public float Side2 { get { return _side2; } }
        #endregion

        #region methods
        public Rectangle(float side1, float side2) : base(side1)
        {
            _side2 = side2;
        }

        public override float GetArea()
        {
            return Side1 * Side2;
        }

        public override string ToString()
        {
            return $"Прямокутник, довжина сторін: {Side1} та {Side2}";
        }
        #endregion
    }
}
