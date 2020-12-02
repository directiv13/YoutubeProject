using System;

namespace BusinessLogic.Exceptions
{
    class BadLoginException : Exception
    {
        public BadLoginException(string message)
            : base(message)
        { }
        public BadLoginException(string message, Exception innerException)
            : base(message, innerException)
        {}

    }
}
