using System;

namespace oop_coursework
{
    class CarInsurance : AbstractInsurance
    {
        public CarInsurance(string clientName, string docName, string insuredItem, bool isVIPuser) : base(clientName, docName, insuredItem, isVIPuser) { }
        protected override void Calculate()
        {
            DocName = "Car insurance";
            Price *= 1600;
            MaxPayOut *= 1200000;
        }
    }
}