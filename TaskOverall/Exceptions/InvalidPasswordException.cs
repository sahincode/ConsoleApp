using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOverall.Exceptions
{
    internal class InvalidPasswordException : Exception
    {
         public InvalidPasswordException() { }
        public InvalidPasswordException(string message) :base(message){ }
    }
}
