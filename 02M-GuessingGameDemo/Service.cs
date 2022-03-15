using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02M_GuessingGameDemo
{
    public class Service
    {
        //GuessCount
        //MaxNum
        //Target

        //handles business process, state of application
        private Random _random = new Random();   //also can be written: private readonly Random _random = new();


        public int GuessCount { get; set; }
        public int TargetNum { get; private set; }
        public int MaxNum { get; private set; }

        public void CreateRandomNumber(int maxVal)
        {
            MaxNum = maxVal;
            TargetNum = _random.Next(1, MaxNum + 1);
        }

        /*CONSTRUCTOR
        public Service(int maxNumber)
        {
            MaxNum = maxNumber;
        }*/

    }
}
