using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOverall.Models;

namespace TaskOverall.Controllers
{
    internal static class UserController
    {
        public static void Register(string name, string surname, string password)
        {
            User user = new User(name, surname);
           
           
                user.Password = password;
           BlogDatabase.Users.Add(user);
           
        }
         public static bool  Login( string username ,string password )
        {
           if(BlogDatabase.Users!=null)
            {
                foreach (User user in BlogDatabase.Users)
                {


                    if (user.UserName == username && user.Password == password)
                    {
                        return true;
                    }

                }
               
            }
            return false;
        }
    }
}
