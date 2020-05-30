using System;
using System.Collections.Generic;

namespace oop_coursework
{
    // !Observer
    class Company
    {
        public static List<AbstractInsurance> registeredPolicies = new List<AbstractInsurance>();
        public static void NotifyCreatedPolicies(float newPrice, float newMaxPayOut)
        {
            foreach (AbstractInsurance insurance in registeredPolicies)
            {
                insurance.UpdatePricePolitics(newPrice, newMaxPayOut);
            }
        }
    }
}