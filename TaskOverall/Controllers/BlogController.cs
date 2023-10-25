using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOverall.Exceptions;
using TaskOverall.Models;

namespace TaskOverall.Controllers
{
    internal static class BlogController
    {


        public static void AddBlog(Blog blog)
        {
            if (blog != null) BlogDatabase.Blogs.Add(blog);
            else
            {
                throw new BlogNotFound(" the given Blog is null");
            }

        }
        public static Blog GetBlogById(int? id)
        {
            Blog blog = BlogDatabase.Blogs.Find(blog => blog.Id == id);
            if (blog != null) return blog;
            else
            {
                throw new BlogNotFound(" the given Blog which Id is equal to given id is not exist ");
            }


        }
        public static void RemoveBlog(int? id)
        {
            Blog blog = GetBlogById(id);
            if (blog != null)
            {
                BlogDatabase.Blogs.Remove(blog);
            }
            else
            {
                throw new BlogNotFound(" the given Blog which Id is equal to given id is not exist ");
            }

        }
        public static List<Blog> GetAllBlogs()
        {
            return BlogDatabase.Blogs;
        }
        public static List<Blog> GetBlogsByValue(string value)
        {
            var blogs = BlogDatabase.Blogs.FindAll(
               blog => blog.Title.ToLower().Contains(value.ToLower())
           || blog.Description.ToLower().Contains(value.ToLower())
           );
            if (blogs != null) return blogs;
            else
            {
                throw new BlogNotFound(" the given Blog which Id is equal to given id is not exist ");

            }

        }


    }
}
