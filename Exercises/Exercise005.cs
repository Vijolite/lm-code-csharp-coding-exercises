using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            if (input ==null) return false;
            else
            {
                string alphabet = "abcdefghijklmnopqrstuvwxyz";
                input = input.ToLower();
                foreach (char letter in alphabet) 
                {
                    if (input.IndexOf(letter)==-1) return false;

                }

                return true;
            }
        }
    }
}
