using System;

namespace oop_coursework
{
    class ChangePricesCommand : AbstractCommand
    {
        public override object HandleRequest(string req)
        {
            if (req.Equals("-changeprices"))
            {
                Console.WriteLine("Enter new price coefficient");
                string newPriceCoefStr = Console.ReadLine();
                float newPriceCoef = -1;
                Console.WriteLine("Enter new max pay out coefficient");
                string newMaxPayOutStr = Console.ReadLine();
                float newMaxPayOut = -1;
                if (float.TryParse(newPriceCoefStr, out newPriceCoef) && float.TryParse(newMaxPayOutStr, out newMaxPayOut) && newPriceCoef > 0 && newMaxPayOut > 0)
                {
                    Company.NotifyCreatedPolicies(newPriceCoef, newMaxPayOut);
                }
                else
                {
                    Console.WriteLine("You have entered invalid number. Try again");
                }
                return "";
            }
            return base.HandleRequest(req);
        }
    }
}