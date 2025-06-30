namespace Practic_8._2
{
    internal class Parallelogram
    {
        #region fields
        private float _side1;

        public float Side1 { get { return _side1; } }
        #endregion

        #region methods
        public Parallelogram(float side1)
        {
            _side1 = side1;
        }

        public virtual float GetArea()
        {
            return -1f;
        }
        public override string ToString()
        {
            return $"Початкова фігура, довжина однієї строни: {Side1}";
        }
        #endregion
    }
}
