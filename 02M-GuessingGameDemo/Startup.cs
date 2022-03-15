using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02M_GuessingGameDemo
{
    public class Startup
    {
        //TODO: what properties do i need?

        //TODO: Add methods
        private Service _service = new Service();

        public void Run()
        {
            int maxNum = View.GetMaxNum();
            _service.CreateRandomNumber(maxNum);

        }

        public void CheckGuess()
        {
            View.DisplayMessage("Guess a number between 1 and ....");
        }
    }
}
