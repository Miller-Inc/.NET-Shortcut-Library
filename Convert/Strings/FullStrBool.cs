using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDLibrary.Convert.Strings
{
    public class FullStrBool
    {
        public static bool GetBool(string input) 
        {
            bool check = true;
            var yea = new List<string> { "yes", "yeah", "true", "y", "e", "s", "yea", "ok", "okay", "duh", "", " " };
            var ney = new List<string> { "no", "not", "false", "n", "o", "nah", "nope", "not today", "what do you think?", "exit", "e" };
            while (check)
            {
                input = input.ToLower();
                for (var i = 0; i < yea.Count(); i++)
                {
                    if (input == yea[i])
                    {
                        return true;
                    }
                }
                for (var i = 0; i < ney.Count(); i++)
                {
                    if (input == ney[i])
                    {
                        return false;
                    }
                }
                Console.WriteLine("Your input was not understood, try again...");
                input = Console.ReadLine();
            }
                return false;
        }
        public static bool TryBool(string input)
        {
            var yea = new List<string> { "yes", "yeah", "true", "y", "e", "s", "yea", "ok", "okay", "duh", "", " " };
            var ney = new List<string> { "no", "not", "false", "n", "o", "nah", "nope", "not today", "what do you think?", "exit", "e" };
            input = input.ToLower();
            for (var i = 0; i < yea.Count(); i++)
            {
                if (input == yea[i])
                {
                    return true;
                }
            }
            for (var i = 0; i < ney.Count(); i++)
            {
                if (input == ney[i])
                {
                    return false;
                }
            }
            return false;
        }
    }
}
