using System;

namespace oop_coursework
{
    class RegisterUser : AbstractCommand
    {
        public override object HandleRequest(string req)
        {
            if (req.Equals("-register"))
            {
                Console.Clear();
                Console.WriteLine("Enter name of user");
                string username = Console.ReadLine();
                Console.WriteLine("Enter age of user");

                int age = -1;
                if (!Int32.TryParse(Console.ReadLine(), out age))
                {
                    return "You have entered invalid number";
                }
                Console.WriteLine("Enter whether user wants to become VIP (true or false");
                bool isUserVIP = Boolean.Parse(Console.ReadLine());
                User newUser;
                if (isUserVIP)
                {
                    newUser = new VIPUser(username, age);
                }
                else
                {
                    newUser = new StandartUser(username, age);
                }
                AuthSystem.RegisterUser(newUser);
                return $"User {username} was successfully registered!";
            }
            return base.HandleRequest(req);
        }
    }
}