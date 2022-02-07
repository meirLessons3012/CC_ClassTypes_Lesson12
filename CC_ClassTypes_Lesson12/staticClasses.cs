using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_ClassTypes_Lesson12
{
    internal class NormalClass
    {
        public static int MyProperty { get; set; }

        public NormalClass()
        {
            
        }
    }

    public static class UserManagment
    {
        public static User[] Users { get; set; }

        static UserManagment()
        {
            Users = new User[10];
        }

        public static bool ValidatePassword(string newPassword)
        {
            if(true)
            {
                return true;
            }
            return false;
        }
        //public UserManagment()
        //{

        //}
    }

    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
