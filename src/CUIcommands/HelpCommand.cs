using System;

namespace oop_coursework
{
    class HelpCommand : AbstractCommand
    {
        public override object HandleRequest(string req)
        {
            if (req.Equals("-help"))
            {
                Console.Clear();
                // todo to finish this
                string response = "-login to log user in\n";
                response += "-newpolicy to create policy\n";
                response += "-exit to exit the program";
                return response;
            }
            else
            {
                return base.HandleRequest(req);
            }
        }
    }
}