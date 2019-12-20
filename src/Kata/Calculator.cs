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

            var separator = new []{",","\n"};
            if (input.StartsWith("//"))
            {
                var split = input.Split("\n");
                separator = new[] {split.First().Replace("//", "")};
                input = split.Last();
            }
            var strings = input.Split(separator,StringSplitOptions.None).Select(int.Parse);
            return strings.Sum();
        }
    }
}