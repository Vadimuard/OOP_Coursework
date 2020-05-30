using System;

namespace oop_coursework
{
    class ShowCommand : AbstractCommand
    {
        public override object HandleRequest(string req)
        {
            if (req.Equals("-showinfo"))
            {
                string response = "";
                if (AuthSystem.СurrentUser == null)
                {
                    response = "No user is logged in. To show user`s info he has to be logged in";
                }
                else
                {
                    AuthSystem.СurrentUser.ShowInfo();
                }
                return response;
            }
            return base.HandleRequest(req);
        }
    }
}