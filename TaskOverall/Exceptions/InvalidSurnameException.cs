﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOverall.Exceptions
{
    internal class InvalidSurnameException:Exception
    {
        public InvalidSurnameException() { }
         public InvalidSurnameException(string message) : base(message) { }
    }
}
