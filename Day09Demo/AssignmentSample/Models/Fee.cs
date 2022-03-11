namespace Day09Demo.AssignmentSample
{
    public struct Fee
    {
        private double _value;

        public Fee(double value)
        {
            if (value < 0)
                throw new InvalidFeeException("Fee cannot be a -ve number!");

            _value = value;
        }

        public static implicit operator Fee(double value)
        {
            return new Fee(value);
        }

        public static Fee operator +(Fee first, Fee second)
        {
            return new Fee(first._value + second._value);
        }

        public override string ToString()
        {
            return $"{_value:N0}";
        }
    }
}