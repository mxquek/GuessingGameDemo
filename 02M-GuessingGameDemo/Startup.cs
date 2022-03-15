using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02M_GuessingGameDemo
{
    public class Startup
    {
        private Service _service = new Service();

        public void Run()
        {
            int maxNum = View.GetMaxNum();
            _service.CreateRandomNumber(maxNum);

            while (true)
            {
                if (CheckGuess())
                {
                    break;
                }
            }

        }

        public bool CheckGuess()
        {
            View.DisplayMessage($"Guess a number between 1 and {_service.MaxNum}.");
            int userGuess = View.GetGuess(_service.MaxNum);

            _service.GuessCount++;

            if (userGuess == _service.TargetNum)
            {
                View.DisplayMessage($"You win! The number was {_service.TargetNum} and it took {_service.GuessCount} guesses.");
                return true;
            }
            else if (userGuess < _service.TargetNum)
            {
                View.DisplayMessage("Too low.");
                return false;
            }
            else
            {
                View.DisplayMessage("Too high.");
                return false;
            }
        }
    }
}
