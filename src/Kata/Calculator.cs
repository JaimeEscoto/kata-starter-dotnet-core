using System;

namespace Kata
{
    public class Calculator
    {
        public int Add(string input)
        {
            if(String.IsNullOrEmpty(input)) 
                return 0;
            if (input.Contains(","))
            {
                return int.Parse(input[0].ToString()) + int.Parse(input[2].ToString());
            }
            return int.Parse(input);
        }
    }
}