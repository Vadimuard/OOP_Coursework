using System;

// !template and decorator

namespace oop_coursework
{
    abstract class AbstractInsurance : Document
    {
        protected string InsuredItem;
        public float Price = 1;
        public float MaxPayOut = 1;
        abstract protected void Calculate();
        private bool IsUserVIP = false;
        public AbstractInsurance(string clientName, string docName, string insuredItem, bool isVIPuser) : base(docName, clientName)
        {
            OwnerName = clientName;
            InsuredItem = insuredItem;
            IsUserVIP = isVIPuser;
            if (isVIPuser)
            {
                MaxPayOut = 2;
                Price = (float)1.5;
            }
        }
        public override void FormDocument()
        {
            Console.WriteLine($"{OwnerName} has insured {InsuredItem} using {DocName}. It cost him {Price}uah and max sum of payout reaches {MaxPayOut}uah. Insurance period started at {Date}");
        }
        public void CreatePolicy()
        {
            Calculate();
            RegisterPolicy();
            FormDocument();
        }
        public void UpdatePricePolitics(float newPrice, float newMaxPayout)
        {
            this.Price = newPrice;
            this.MaxPayOut = newMaxPayout;
            if (IsUserVIP)
            {
                Price *= (float)1.5;
                MaxPayOut *= 2;
            }
            CreatePolicy();
        }
    }
}