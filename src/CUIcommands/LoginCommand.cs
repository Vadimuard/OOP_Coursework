using System;

namespace oop_coursework
{
    class LoginCommand : AbstractCommand
    {
        public override object HandleRequest(string req)
        {
            Console.Clear();
            if (req.Equals("-login"))
            {
                Console.WriteLine("Please enter the name of user:");
                string username = Console.ReadLine();
                if (AuthSystem.UsersDB.ContainsKey(username))
                {
                    AuthSystem.UsersDB[username].ShowInfo();
                    AuthSystem.AuthorizeUser(username);
                    return $"{username} was successfully logged in";
                }
                else
                {
                    return $"{username} is not regestered. Please register at first";
                }
            }
            return base.HandleRequest(req);
        }
    }
}