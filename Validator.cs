using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPOE
{
    class Validator
    {
        public static bool IsValidInput(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        public static bool IsExit(string input)
        {
            return input == "exit" || input == "quit";
        }
    }
}
