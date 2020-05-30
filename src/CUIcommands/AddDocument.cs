using System;

namespace oop_coursework
{
    class AddDocument : AbstractCommand
    {
        public override object HandleRequest(string req)
        {
            if (req.Equals("-adddocument"))
            {
                string response = "";
                if (AuthSystem.СurrentUser == null)
                {
                    response = "No user is logged in. To add a document user has to be logged in";
                }
                else
                {
                    Console.WriteLine("Enter what document user wants to add");
                    string document = Console.ReadLine();
                    Document newDocument = new Document(document, AuthSystem.СurrentUser.Name);
                    AuthSystem.СurrentUser.documents.Add(document, newDocument);
                    response = $"{AuthSystem.СurrentUser.Name} has added {document} to his account";
                }
                return response;
            }
            return base.HandleRequest(req);
        }
    }
}