using System;
using System.Linq;
using System.Text;

namespace Ultra_Sum
{
    public class Calculator
    {
        public class StringProcessor
        {
            public string KeepOnlyNumberAndPoint(string input)
            {
                if (string.IsNullOrEmpty(input)) return string.Empty;

                StringBuilder cleanedString = new StringBuilder();
                bool pointEncountered = false;

                foreach (char c in input)
                {
                    if (char.IsDigit(c))
                    {
                        cleanedString.Append(c);
                    }
                    else if (c == '.' && !pointEncountered)
                    {
                        cleanedString.Append(c);
                        pointEncountered = true;
                    }
                }

                // Handling case where the string is just a point or starts/ends with a point
                string result = cleanedString.ToString();
                if (result == "." || result.StartsWith(".") || result.EndsWith("."))
                {
                    result = result.Trim('.');
                }

                return result;
            }
        }
        private readonly StringProcessor _stringProcessor = new StringProcessor();

        public string getNumberOnly(string s)
        {
            return _stringProcessor.KeepOnlyNumberAndPoint(s);
        }
        public bool AreInputsVerified(string a, string b)
        {
            return IsNumericString(a) && IsNumericString(b);
        }

        private bool IsNumericString(string s)
        {
            return s.All(char.IsDigit);
        }

        public string FindBigOne(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return "a";
            }
            else if (a.Length < b.Length)
            {
                return "b";
            }
            else // Equal lengths, compare digit by digit
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > b[i])
                        return "a";
                    else if (a[i] < b[i])
                        return "b";
                }
            }
            // Strings are equal
            return "a";
        }

        public string AddNumStrings(string str1, string str2)
        {
            StringBuilder result = new StringBuilder();
            int carry = 0, sum;

            // Ensure str1 is not shorter than str2
            while (str1.Length < str2.Length) str1 = "0" + str1;
            while (str2.Length < str1.Length) str2 = "0" + str2;

            for (int i = str1.Length - 1; i >= 0; i--)
            {
                sum = (int)(str1[i] - '0') + (int)(str2[i] - '0') + carry;
                carry = sum / 10;
                result.Insert(0, sum % 10);
            }
            if (carry != 0) result.Insert(0, carry);

            return result.ToString();
        }

        public string SubtractNumStrings(string str1, string str2)
        {
            StringBuilder result = new StringBuilder();
            int borrow = 0, diff;

            // Ensure str1 is not shorter than str2
            while (str1.Length < str2.Length) str1 = "0" + str1;
            while (str2.Length < str1.Length) str2 = "0" + str2;

            for (int i = str1.Length - 1; i >= 0; i--)
            {
                diff = ((int)(str1[i] - '0') - (int)(str2[i] - '0') - borrow);
                if (diff < 0)
                {
                    diff += 10;
                    borrow = 1;
                }
                else
                {
                    borrow = 0;
                }
                result.Insert(0, diff);
            }

            // Remove leading zeros
            while (result.Length > 1 && result[0] == '0')
            {
                result.Remove(0, 1);
            }

            return result.ToString();
        }

        public string MultiplyNumStrings(string str1, string str2)
        {
            string result = "0";

            for (int i = str2.Length - 1; i >= 0; i--)
            {
                string row = MultiplySingleDigit(str1, str2[i]);
                for (int j = 0; j < str2.Length - 1 - i; j++)
                {
                    row += "0";
                }
                result = AddNumStrings(result, row);
            }
            return result;
        }

        private string MultiplySingleDigit(string str, char digit)
        {
            int carry = 0, product;
            StringBuilder result = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                product = ((int)(str[i] - '0') * (int)(digit - '0')) + carry;
                carry = product / 10;
                result.Insert(0, product % 10);
            }
            if (carry != 0) result.Insert(0, carry);

            return result.ToString();
        }

        public string DivideNumStrings(string dividend, string divisor)
        {
            if (divisor == "0")
                throw new DivideByZeroException("Cannot divide by zero");

            if (dividend == "0")
                return "0";

            StringBuilder quotient = new StringBuilder();
            string remainder = "0";

            // Iterate through each digit of the dividend
            for (int i = 0; i < dividend.Length; i++)
            {
                // Append the current digit to the remainder
                remainder = remainder + dividend[i];

                // Remove leading zeros from the remainder
                while (remainder.StartsWith("0") && remainder.Length > 1)
                {
                    remainder = remainder.Substring(1);
                }

                int multiple = 0;
                // Determine how many times the divisor can go into the current remainder
                while (FindBigOne(remainder, divisor) != "b")
                {
                    remainder = SubtractNumStrings(remainder, divisor);
                    multiple++;
                    // Remove leading zeros after subtraction
                    while (remainder.StartsWith("0") && remainder.Length > 1)
                    {
                        remainder = remainder.Substring(1);
                    }
                }

                // Append the found multiple to the quotient
                quotient.Append(multiple);
            }

            // Remove leading zeros from the quotient
            while (quotient.Length > 1 && quotient[0] == '0')
            {
                quotient.Remove(0, 1);
            }

            return quotient.ToString();
        }

        public string DivideNumStrings(string dividend, string divisor, double decimalPlaces = 2)
        {
            if (divisor == "0")
                throw new DivideByZeroException("Cannot divide by zero");

            if (dividend == "0")
                return "0";

            StringBuilder quotient = new StringBuilder();
            string remainder = "0";
            bool decimalPointAdded = false;

            for (int i = 0; i < dividend.Length + decimalPlaces; i++)
            {
                // Append the current digit to the remainder, or a zero after the original dividend length
                remainder = remainder + (i < dividend.Length ? dividend[i] : '0');

                // Remove leading zeros from the remainder
                while (remainder.StartsWith("0") && remainder.Length > 1)
                {
                    remainder = remainder.Substring(1);
                }

                int multiple = 0;
                // Determine how many times the divisor can go into the current remainder
                while (FindBigOne(remainder, divisor) != "b")
                {
                    remainder = SubtractNumStrings(remainder, divisor);
                    multiple++;
                    // Remove leading zeros after subtraction
                    while (remainder.StartsWith("0") && remainder.Length > 1)
                    {
                        remainder = remainder.Substring(1);
                    }
                }

                // Append the found multiple to the quotient
                quotient.Append(multiple);

                // If we've reached the end of the original dividend and haven't added the decimal point yet, add it.
                if (i == dividend.Length - 1 && decimalPlaces > 0)
                {
                    quotient.Append('.');
                    decimalPointAdded = true;
                }
            }

            // Remove trailing zeros after the decimal point, if it was added
            if (decimalPointAdded)
            {
                while (quotient[quotient.Length - 1] == '0')
                {
                    quotient.Remove(quotient.Length - 1, 1);
                }
                // Remove the decimal point if it's the last character
                if (quotient[quotient.Length - 1] == '.')
                {
                    quotient.Remove(quotient.Length - 1, 1);
                }
            }

            return quotient.ToString();
        }



    }
}
