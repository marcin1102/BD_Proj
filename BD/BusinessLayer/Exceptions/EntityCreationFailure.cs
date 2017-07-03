using System;
using System.Runtime.Serialization;

namespace BusinessLayer.Exceptions
{
    [Serializable]
    internal class EntityCreationFailure : Exception
    {
        public EntityCreationFailure()
        {
        }

        public EntityCreationFailure(string message) : base(message)
        {
        }

        public EntityCreationFailure(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EntityCreationFailure(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}