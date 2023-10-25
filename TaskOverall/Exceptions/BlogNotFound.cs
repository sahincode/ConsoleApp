using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOverall.Exceptions
{
    internal class BlogNotFound : Exception
    {
         public BlogNotFound() { }
         public BlogNotFound( string Message):base(Message) { }
    }
}
