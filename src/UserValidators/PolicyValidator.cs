using System;

namespace oop_coursework
{
    class PolicyValidator
    {
        public static bool CheckIfPolicyAvailable(string insuranceType, User user)
        {
            string response = "";
            if (user.documents.ContainsKey("passport") && user.documents.ContainsKey("ID-number"))
            {
                response = $"{user.Name} has all required documents.";
            }
            else
            {
                Console.WriteLine($"{user.Name} does not have passport / ID-number, so the policy can not be registered");
                return false;
            }
            if (user.possessions[insuranceType].IsInsured)
            {
                Console.WriteLine(response + $"{insuranceType} is already insured and can not be insured at this moment");
                return false;
            }
            else
            {
                Console.WriteLine(response + $"{insuranceType} was successfully insured");
                return true;
            }
        }
    }
}