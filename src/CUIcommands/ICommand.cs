using System;

namespace oop_coursework
{
    interface ICommand
    {
        ICommand SetNext(ICommand command);
        object HandleRequest(string request);
    }
}