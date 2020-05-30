using System;
using System.Security.Cryptography;

namespace oop_coursework
{
    class HouseInsurance : AbstractInsurance
    {
        public HouseInsurance(string clientName, string docName, string insuredItem, bool isVIPuser) : base(clientName, docName, insuredItem, isVIPuser) { }
        protected override void Calculate()
        {
            DocName = "House insurance";
            Price *= 5000;
            MaxPayOut *= 2000000;
        }
    }
}