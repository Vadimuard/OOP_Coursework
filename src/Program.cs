using System;
using System.Collections.Generic;
namespace oop_coursework
{
    class Program
    {
        static void Main(string[] args)
        {
            // User user = new StandartUser("Oleg Budko", 20, null);
            // user.ShowInfo();
            AuthSystem.RegisterUser(new VIPUser("Oleg Budko", 20));
            Cui cui = Cui.GetInstance();
            cui.Start();
        }
    }
}
