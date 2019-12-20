using System;

namespace Kata
{
    public class Calculator
    {
        public int Add(string input)
        {
            if(String.IsNullOrEmpty(input)) 
                return 0;
            return int.Parse(input);
        }
    }
}