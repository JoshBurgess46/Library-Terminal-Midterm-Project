using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Terminal
{
    class Validator
    {
        public bool IsInt(string input)
        {
            return int.TryParse(input out int variable)
        }

        public bool IsYesNo(string input)
        {
            if (input == "yes" || input == "y" || input == "no" || input == "n")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Is
    }
}
