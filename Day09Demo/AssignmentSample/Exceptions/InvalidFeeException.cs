using System.Runtime.Serialization;

namespace Day09Demo.AssignmentSample
{
    [Serializable]
    internal class InvalidFeeException : Exception
    {
        public InvalidFeeException()
        {
        }

        public InvalidFeeException(string message) : base(message)
        {
        }

        public InvalidFeeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidFeeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}