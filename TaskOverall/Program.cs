using System.Text.RegularExpressions;
using System.Xml.Linq;
using TaskOverall.Controllers;
using TaskOverall.enums;
using TaskOverall.Models;

namespace TaskOverall
{
    internal class Program
    {
        static public  bool islogin = false;


        static void Main(string[] args)
        {
            
            
           
            do
            {
                Console.WriteLine("Please if you before registered  Login directly," +
                " vise versa choose Register:\n" +
                "1.Register\n " +
                "2.Login:");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        CreateUser();
                        break;
                    case "2":
                        Login();
                        break;

                }
            } while (!islogin);





            //}
            string menucommand=" ";
            do
            {
                Console.WriteLine("1. Blog elave et\n" +
               "2. Blog sil\r\n" +
               "3. Blog detail\r\n" +
               "4. Butun bloglara bax\r\n" +
               "5. Bloglari filterle\r\n" +
               "0. Proqramı bitir\r\n");
                 menucommand = Console.ReadLine();
                switch (menucommand)
                {
                    case "1":
                        AddBlog();
                        break;
                    case "2":
                        AddBlog();
                        break;
                    case "3":
                        DeleteBlog();
                        break;
                    case "4":
                        BlogController.GetAllBlogs();
                        break;
                    case "5":
                        FilterBlogs();
                        break;

                    case "0":
                        break;
                    default:
                        Console.WriteLine("operation is not valid ");
                        break;


                }

            } while (menucommand != "0");
        }
        public static void CreateUser()
        {
            string name;
            string surname;
            string password;
            do
            {
                Console.WriteLine("Please enter user name :");
                name = Console.ReadLine();


            } while (!Regex.IsMatch(name, "^[A-Z][a-zA-Z]*$"));
            do
            {
                Console.WriteLine("Please enter user  surname  :");
                surname = Console.ReadLine();

            } while (!Regex.IsMatch(surname, "^[A-Z][a-zA-Z]*$"));
            do
            {
                Console.WriteLine("Please enter user password  :");
                password = Console.ReadLine();

            } while (!User.CheckPassword(password));
            UserController.Register(name, surname,password);




        }
        public static void Login()
        {
            string username;
            string password;

            Console.WriteLine("Please enter user username :");
            username = Console.ReadLine();
            Console.WriteLine("Please enter user password :");
            password = Console.ReadLine();


            if (UserController.Login(username, password))
            {
                 islogin= true;
                
            }
         
        }
        public static void AddBlog()
        {
            string blogType;
            string title;
            string description;
            do
            {
                Console.WriteLine("Please enter  Blogtype  \n:1 - Programming\n 2 - Educational\n 3 - Thriller");
                blogType = Console.ReadLine();

            } while (!(blogType == "1" || blogType == "2" || blogType == "3"));
            BlogType trueType = (BlogType)int.Parse(blogType);
            Console.WriteLine("Please enter  title :");
            title = Console.ReadLine();
            Console.WriteLine("Please enter description:");
            description = Console.ReadLine();
            Blog blog = new Blog()
            {
                BlogType = trueType,
                Title = title,
                Description = description

            };
            BlogDatabase.Blogs.Add(blog);

        }
        public static void DeleteBlog()
        {
            string strid;
            int trueid;
            do
            {
                Console.Write("Please enter id of Blog which you want to delete :");
                strid = Console.ReadLine();

            } while (!int.TryParse(strid, out trueid));

            BlogController.RemoveBlog(trueid);
        }
        public static void FilterBlogs()
        {
            Console.Write("Please enter blog info about blogs which you interest in :");
            string value = Console.ReadLine();
            BlogController.GetBlogsByValue(value);
        }
    }
}