using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOverall.Models
{
    internal static class BlogDatabase
    {
         public static List <Blog >Blogs  { get; set; }
         public static List<User> Users =new List<User> ();
    }
}
