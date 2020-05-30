using System;

namespace oop_coursework
{
    abstract class AbstractCommand : ICommand
    {
        private ICommand _nextCommand;
        public ICommand SetNext(ICommand command)
        {
            this._nextCommand = command;
            return command;
        }
        public virtual object HandleRequest(string req)
        {
            if (this._nextCommand != null)
            {
                return this._nextCommand.HandleRequest(req);
            }
            else
            {
                return null;
            }
        }
    }
}