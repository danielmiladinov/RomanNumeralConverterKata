using System;
using System.Text;
using System.Collections.Generic;

namespace RomanNumerals.Converter {

    public class RomanNumeralConverter {
        private static Dictionary<char, int> symbols = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        public static int romanToArabic(string numeral) {
            int sum = 0;
            int previousSymbolValue = 0;
            int timesSameSymbolWasSeen = 1;

            foreach (char s in numeral) {
                if (symbols.ContainsKey(s)) {
                    int symbolValue = symbols[s];

                    if (symbolValue == previousSymbolValue) {
                        timesSameSymbolWasSeen++;
                    } else {
                        timesSameSymbolWasSeen = 1;
                    }

                    if (timesSameSymbolWasSeen > 3) {
                        return 0;
                    }

                    if (sum > 0 && symbolValue > previousSymbolValue) {
                        sum += (symbolValue - (previousSymbolValue * 2));
                    } else {
                        sum += symbolValue;
                    }

                    previousSymbolValue = symbolValue;
                } else {
                    return 0;
                }
            }

            return sum;
        }

        public static string arabicToRoman(int arabic) {
            var roman = new StringBuilder();

            if (arabic > 3) {
                if (arabic == 4) {
                    roman.Append("IV");
                } else {
                    roman.Append("V");
                }
            } else {
                while (arabic-- > 0) {
                    roman.Append("I");
                }
            }

            return roman.ToString();
        }
    }
}
