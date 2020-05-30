using System;

namespace oop_coursework
{
    class AddPossessionCommand : AbstractCommand
    {
        public override object HandleRequest(string req)
        {
            if (req.Equals("-addpossession"))
            {
                string response = "";
                if (AuthSystem.СurrentUser == null)
                {
                    response = "No user is logged in. To add a possession user has to be logged in";
                }
                else
                {
                    Console.WriteLine("Enter what possession user wants to add");
                    string possession = Console.ReadLine();
                    if (possession.Equals("car") || possession.Equals("house"))
                    {
                        bool isAdult = AuthSystem.CheckIfUserHasPermission(AuthSystem.СurrentUser);
                        if (isAdult)
                        {
                            Console.WriteLine("User is adult and is allowed to insure car or house");
                        }
                        else
                        {
                            return "User is not adult and can not insure car or house";
                        }
                    }
                    UserPossession userPossession = new UserPossession(possession, false);
                    AuthSystem.СurrentUser.possessions.Add(possession, userPossession);
                    response = $"{AuthSystem.СurrentUser.Name} has added {possession} to his account";
                }
                return response;
            }
            return base.HandleRequest(req);
        }
    }
}