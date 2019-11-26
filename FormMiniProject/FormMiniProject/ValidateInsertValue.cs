using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FormMiniProject
{
    public class ValidateInsertValue
    {
        public static bool isValidSgFin(string strValueToCheck)
        {
            strValueToCheck = strValueToCheck.Trim();

            Regex objRegex = new Regex("^(s|t)[0-9]{7}[a-jz]{1}$", RegexOptions.IgnoreCase);

            if (!objRegex.IsMatch(strValueToCheck))
            {
                return false;
            }

            string strNums = strValueToCheck.Substring(1, 7);

            int intSum = 0;
            int checkDigit = 0;
            string checkChar = "";
            intSum = Convert.ToUInt16(strNums.Substring(0, 1)) * 2;
            intSum = intSum + (Convert.ToUInt16(strNums.Substring(1, 1)) * 7);
            intSum = intSum + (Convert.ToUInt16(strNums.Substring(2, 1)) * 6);
            intSum = intSum + (Convert.ToUInt16(strNums.Substring(3, 1)) * 5);
            intSum = intSum + (Convert.ToUInt16(strNums.Substring(4, 1)) * 4);
            intSum = intSum + (Convert.ToUInt16(strNums.Substring(5, 1)) * 3);
            intSum = intSum + (Convert.ToUInt16(strNums.Substring(6, 1)) * 2);

            if (strValueToCheck.Substring(0, 1).ToLower() == "t")
            {
                //prefix T
                intSum = intSum + 4;
            }

            checkDigit = 11 - (intSum % 11);

            checkChar = strValueToCheck.Substring(8, 1).ToLower();

            if (checkDigit == 1 && checkChar == "a")
            {
                return true;
            }
            else if (checkDigit == 2 && checkChar == "b")
            {
                return true;
            }
            else if (checkDigit == 3 && checkChar == "c")
            {
                return true;
            }
            else if (checkDigit == 4 && checkChar == "d")
            {
                return true;
            }
            else if (checkDigit == 5 && checkChar == "e")
            {
                return true;
            }
            else if (checkDigit == 6 && checkChar == "f")
            {
                return true;
            }
            else if (checkDigit == 7 && checkChar == "g")
            {
                return true;
            }
            else if (checkDigit == 8 && checkChar == "h")
            {
                return true;
            }
            else if (checkDigit == 9 && checkChar == "i")
            {
                return true;
            }
            else if (checkDigit == 10 && checkChar == "z")
            {
                return true;
            }
            else if (checkDigit == 11 && checkChar == "j")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        public static bool hasSpecialChar(String input)
        {
            String specialChar = @"~!@#$%^&*()_+-={}[]:';<>?,/ ";
            foreach (var item in specialChar) {
                if (input.Contains(item)) return true;
            }
            return false;
        }
        public static Boolean checkphoneNo(String phoneNumber) {
            if (phoneNumber.All(char.IsDigit) && phoneNumber.Length == 8) {
                return true;
            }
            return false;

        }


        public static Boolean checkEmail(String emailValue)
        {

            String[] splitValueList = emailValue.Split('@');
            if (emailValue.Contains("@") && splitValueList[0].Length > 0 && splitValueList[1].Length > 0)
            {
                if (!ValidateInsertValue.hasSpecialChar(splitValueList[0]) && !ValidateInsertValue.hasSpecialChar(splitValueList[1]) && splitValueList[1].Contains("."))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
