using System;

namespace oop_coursework
{
    class HomeCommand : AbstractCommand
    {
        public override object HandleRequest(string req)
        {
            if (req.Equals("-home"))
            {
                Console.Clear();
                return "Welcome to Our Insurance Company!\nType -help to see all commands";
            }
            else
            {
                return base.HandleRequest(req);
            }
        }
    }
}