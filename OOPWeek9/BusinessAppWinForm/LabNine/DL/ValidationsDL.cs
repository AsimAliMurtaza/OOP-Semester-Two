using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessApp.BL
{
    internal class ValidationsDL
    {
        public static bool checkName(string nameItem, List<ProductBL> productData)
        {
            for (int i = 0; i < productData.Count; i++)
            {
                if (nameItem == productData[i].GetProductName())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool checkEmail(string emails)
        {

            for (int i = 0; i < emails.Length; i++)
            {
                if (emails[i] == 64 && emails[emails.Length - 1] == 'm' && emails[emails.Length - 2] == 'o' && emails[emails.Length - 3] == 'c' && emails[emails.Length - 4] == '.')
                {
                    return true;
                }
            }
            return false;
        }

        public static bool checkComma(string usernames)
        {
            bool temp = true;

            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == 44)
                {
                    temp = false;
                }
            }
            return temp;
        }

        public static bool IsAlphanumeric(string input)
        {
            string pattern = "^[a-zA-Z0-9]+$";
            return Regex.IsMatch(input, pattern);
        }

        public static bool IsEmptySpace(string input)
        {
            for(int i = 0;i < input.Length;i++)
            {
                if (input[i] == ' ')
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsEightLength(string input)
        {
            if(input.Length >= 8)
            {
                return true;
            }
            return false;
        }
    }
}
