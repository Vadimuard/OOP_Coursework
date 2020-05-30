using System;

namespace oop_coursework
{
    class NewPolicyCommand : AbstractCommand
    {
        public override object HandleRequest(string req)
        {
            if (req.Equals("-newpolicy"))
            {
                if (AuthSystem.СurrentUser == null)
                {
                    Console.WriteLine("No user is logged in!");
                }
                else
                {
                    Console.WriteLine("Enter the subject that you want to insure");
                    string subject = Console.ReadLine();
                    User user = AuthSystem.СurrentUser;
                    if (AuthSystem.СurrentUser.possessions != null && AuthSystem.СurrentUser.possessions.ContainsKey(subject))
                    {
                        if (PolicyValidator.CheckIfPolicyAvailable(subject, user))
                        {
                            AbstractInsurance insurance = null;
                            bool isUserVIP = user.ToString().Equals("oop_coursework.VIPUser");
                            if (subject.Equals("car"))
                            {
                                insurance = new CarInsurance(user.Name, "Car insurance", subject, isUserVIP);
                            }
                            else if (subject.Equals("life"))
                            {
                                insurance = new LifeInsurance(user.Name, "Life insurance", subject, isUserVIP);
                            }
                            else if (subject.Equals("health"))
                            {
                                insurance = new HealthInsurance(user.Name, "health", subject, isUserVIP);
                            }
                            else if (subject.Equals("house"))
                            {
                                insurance = new HouseInsurance(user.Name, "house insurance", subject, isUserVIP);
                            }
                            if (insurance != null)
                            {
                                insurance.CreatePolicy();
                                Company.registeredPolicies.Add(insurance);
                            }
                            else
                            {
                                Console.WriteLine($"{subject} is not supposed to be insured");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{user.Name} does not have {subject}");
                    }
                }
                return $"";
            }
            return base.HandleRequest(req);
        }
    }
}