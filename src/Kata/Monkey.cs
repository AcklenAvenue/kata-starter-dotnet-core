using System.Collections;
using System.Collections.Generic;

namespace Kata
{
    public class Monkey
    {
        IList<string> Belly { get; }

        public void Eat(string food)
        {
            Belly.Add(food);
        }
    }
}