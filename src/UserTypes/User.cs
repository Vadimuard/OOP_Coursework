using System;
using System.Collections.Generic;

namespace oop_coursework
{
    abstract class User
    {
        public string Name;
        public Dictionary<string, UserPossession> possessions = new Dictionary<string, UserPossession>();
        public Dictionary<string, Document> documents = new Dictionary<string, Document>();
        public int Age;
        public User(string name, int age)
        {
            UserPossession life = new UserPossession("life", false);
            UserPossession health = new UserPossession("health", false);
            possessions.Add("life", life);
            possessions.Add("health", health);
            Name = name;
            Age = age;
        }
        abstract public void ShowInfo();
    }
}