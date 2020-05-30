using System;

namespace oop_coursework
{
    class Cui
    {
        private static Cui _instance = null;
        private HomeCommand homeCommand = new HomeCommand();
        private HelpCommand helpCommand = new HelpCommand();
        private ExitCommand exitCommand = new ExitCommand();
        private LoginCommand loginCommand = new LoginCommand();
        private NewPolicyCommand newPolicyCommand = new NewPolicyCommand();
        private RegisterUser registerUser = new RegisterUser();
        private AddPossessionCommand addPossessionCommand = new AddPossessionCommand();
        private ShowCommand showCommand = new ShowCommand();
        private AddDocument addDocument = new AddDocument();
        private ChangePricesCommand changePricesCommand = new ChangePricesCommand();
        private Cui()
        {
            homeCommand.SetNext(helpCommand).SetNext(exitCommand).SetNext(loginCommand).SetNext(newPolicyCommand).SetNext(registerUser).
            SetNext(addPossessionCommand).SetNext(showCommand).SetNext(addDocument).SetNext(changePricesCommand);
        }
        public void Start()
        {
            Console.Clear();
            bool isProgramActive = true;
            Console.WriteLine(homeCommand.HandleRequest("-home"));
            while (isProgramActive)
            {
                string req = Console.ReadLine();
                object res = homeCommand.HandleRequest(req);
                if (res == null)
                {
                    Console.WriteLine($"{req} is not an available command! Try something else");
                }
                else if (res.ToString().Equals("False"))
                {
                    isProgramActive = false;
                }
                else
                {
                    Console.WriteLine(res);
                }
            }
        }
        public static Cui GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Cui();
            }
            return _instance;
        }
    }
}