using System;
using System.Collections.Generic;

namespace oop_coursework
{
    class StandartUser : User
    {
        public StandartUser(string name, int age) : base(name, age) { }
        public override void ShowInfo()
        {
            Console.WriteLine($"User {Name} owns:");
            if (possessions != null && possessions.Count != 0)
            {
                foreach (UserPossession possession in possessions.Values)
                {
                    Console.WriteLine($"----{possession.Name}");
                }
            }
            else
            {
                Console.WriteLine("-----------nothing-----------");
            }
            Console.WriteLine($"Also {Name} has given our company these documents:");
            if (documents != null && documents.Count != 0)
            {
                foreach (Document document in documents.Values)
                {
                    Console.WriteLine($"----{document.DocName}");
                }
            }
            else
            {
                Console.WriteLine("-----------nothing-----------");
            }
        }
    }
}