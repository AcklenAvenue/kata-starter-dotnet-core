using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.Spec
{
    public class TestClass
    {
        public int GetSumOfThirdCharacter(string input)
        {
            var lines = input.Split("\n");
            var thirdCharacters = lines.Select(x => x.Substring(2, 1));
            var numbers = thirdCharacters.Select(int.Parse);
            var sum = numbers.Sum();
            return sum;
        }
        
//        static string[] GetLines(string input)
//        {
//            return new[] { "" };
//        }
    }
}