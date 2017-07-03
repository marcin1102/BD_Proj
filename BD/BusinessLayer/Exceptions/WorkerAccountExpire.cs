using System;
using System.Runtime.Serialization;

namespace BusinessLayer.Exceptions
{
    [Serializable]
    internal class WorkerAccountExpire : Exception
    {
        public WorkerAccountExpire()
        {
        }

        public WorkerAccountExpire(string message) : base(message)
        {
        }

        public WorkerAccountExpire(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WorkerAccountExpire(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}