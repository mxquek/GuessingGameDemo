using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02M_GuessingGameDemo
{
    public class View
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static int GetGuess(int maxNum)
        {
            return Validation.PromptUser4Int("Enter your guess: ", 1, maxNum);
        }

        public static int GetMaxNum()
        {
            return Validation.PromptUser4Int("Enter the max number to guess.");
        }
    }
}
