using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOverall.enums;

namespace TaskOverall.Models
{
    internal class Blog
    {
        private static int _id;
        public int Id { get; private set; }
        public string Title { get;  set; }
        public string Description { get;  set; }
         public BlogType BlogType { get;  set; }
        static Blog()
        {
            _id = 0;
        }
         public Blog()
        {
            _id++;
            Id = _id;
        }

    }
}
