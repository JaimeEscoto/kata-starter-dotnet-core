using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string input)
        {
            if(String.IsNullOrEmpty(input)) 
                return 0;
            var strings = input.Split(",").Select(int.Parse);
            return strings.Sum();
        }
    }
}