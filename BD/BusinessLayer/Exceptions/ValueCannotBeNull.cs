using System;
using System.Runtime.Serialization;

namespace BusinessLayer.Exceptions
{
    [Serializable]
    internal class ValueCannotBeNull : Exception
    {
        public ValueCannotBeNull()
        {
        }

        public ValueCannotBeNull(string message) : base(message)
        {
        }

        public ValueCannotBeNull(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ValueCannotBeNull(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}