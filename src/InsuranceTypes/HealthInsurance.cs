using System;
using System.Security.Cryptography;

namespace oop_coursework
{
    class HealthInsurance : AbstractInsurance
    {
        public HealthInsurance(string clientName, string docName, string insuredItem, bool isVIPuser) : base(clientName, docName, insuredItem, isVIPuser) { }
        protected override void Calculate()
        {
            DocName = "Health insurance";
            Price *= 160;
            MaxPayOut *= 120000;
        }
    }
}