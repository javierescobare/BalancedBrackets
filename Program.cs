using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
    class Program
    {
        const string OpeningBrackets = "([{";
        const string ClosingBrackets = ")]}";

        private static bool CheckBalancedBrackets(string expression)
        {
            var stack = new Stack<char>();
            foreach (char currentBracket in expression)
            {
                if (IsOpeningBracket(currentBracket))
                {
                    stack.Push(currentBracket);
                }
                else if (IsMatchingBracket(currentBracket, stack.Peek()))
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            return stack.Count == 0;
        }

        private static bool IsOpeningBracket(char bracket)
        {
            return OpeningBrackets.Contains(bracket);
        }

        private static bool IsMatchingBracket(char currentBracket, char lastBracket)
        {
            return ClosingBrackets.IndexOf(currentBracket) ==
                OpeningBrackets.IndexOf(lastBracket);
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string ");
            var input = Console.ReadLine();
            var balanced = CheckBalancedBrackets(input);
            System.Console.WriteLine($"Is balanced: {balanced}");
        }
    }
}
