using System;

namespace oop_coursework
{
    class ExitCommand : AbstractCommand
    {
        public override object HandleRequest(string req)
        {
            if (req.Equals("-exit"))
            {
                return false;
            }
            return base.HandleRequest(req);
        }
    }
}