using System;
using System.Runtime.Serialization;

namespace BusinessLayer.Exceptions
{
    [Serializable]
    internal class EntityDoesNotExist : Exception
    {
        public EntityDoesNotExist()
        {
        }

        public EntityDoesNotExist(string message) : base(message)
        {
        }

        public EntityDoesNotExist(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EntityDoesNotExist(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}