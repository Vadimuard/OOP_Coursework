using System;
using System.Globalization;

namespace oop_coursework
{
    class Document
    {
        public string DocName;
        public string Date;
        public string OwnerName;
        protected Guid ID;
        public Document(string docName, string ownerName)
        {
            OwnerName = ownerName;
            DocName = docName;
        }
        protected void RegisterPolicy()
        {
            CultureInfo culture = new CultureInfo("en-GB");
            ID = Guid.NewGuid();
            Date = DateTime.UtcNow.ToString(culture);
        }
        public virtual void FormDocument()
        {
            Console.WriteLine($"{DocName} was registered for {OwnerName} at {Date} with identifier: {ID}");
        }
    }
}