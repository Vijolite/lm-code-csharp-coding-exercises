using System;
using System.Collections.Generic;
using Exercises.Models;
using System.Linq;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            if (word == null)
                return null;
            else if (word == string.Empty)
                return string.Empty;
            else if (word.Length==1)
                return word.ToUpper();
            else
                return char.ToUpper(word[0])+word.Substring(1);
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            return firstName[0]+"."+lastName[0];
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            if (originalPrice<0) throw new ArgumentException("Price cannot be negative. Please enter a valid price.");
            if (vatRate<0) throw new ArgumentException("VAT cannot be negative. Please enter a valid VAT.");
            return Math.Round(originalPrice*(100+vatRate)/100,2);
        }

        public string Reverse(string sentence)
        {
            if (sentence==null)
                return null;
            else 
            {
                string result="";
                for(int i = sentence.Length-1; i >=0 ; i--)
                {
                    result+=sentence[i];
                }
                return result;
            }
        }

        public int CountLinuxUsers(List<User> users)
        {
            return (users==null)?0:users.Where(u=>u.Type=="Linux").ToList().Count;			
        }
    }

}
