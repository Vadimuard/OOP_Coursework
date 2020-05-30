using System;
using System.Security.Cryptography;

namespace oop_coursework
{
    class LifeInsurance : AbstractInsurance
    {
        public LifeInsurance(string clientName, string docName, string insuredItem, bool isVIPuser) : base(clientName, docName, insuredItem, isVIPuser) { }
        protected override void Calculate()
        {
            DocName = "Life insurance";
            Price *= 1200;
            MaxPayOut *= 200000;
        }
    }
}