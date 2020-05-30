using System;
using System.Collections.Generic;
// ! PROXY

namespace oop_coursework
{
    class AuthSystem
    {
        public static Dictionary<string, User> UsersDB = new Dictionary<string, User>();
        public static User СurrentUser = null;
        public static bool RegisterUser(User user)
        {
            if (!UsersDB.ContainsKey(user.Name))
            {
                UsersDB.Add(user.Name, user);
                return true;
            }
            return false;
        }
        public static bool CheckIfUserHasPermission(User user)
        {
            if (user.Age >= 18)
            {
                return true;
            }
            return false;
        }
        public static User AuthorizeUser(string userName)
        {
            СurrentUser = UsersDB[userName];
            return СurrentUser;
        }
    }
}