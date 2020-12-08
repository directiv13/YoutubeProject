using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Exceptions
{
    class BadEmailException:Exception
    {
        public BadEmailException(string message)
            : base(message)
        { }
        public BadEmailException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
