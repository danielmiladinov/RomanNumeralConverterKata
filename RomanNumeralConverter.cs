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

        private static SymbolPattern ones = new SymbolPattern("I", "V", "X");
        private static SymbolPattern tens = new SymbolPattern("X", "L", "C");
        private static SymbolPattern hundreds = new SymbolPattern("C", "D", "M");
        private static SymbolPattern thousands = new SymbolPattern("M");

        public static string arabicToRoman(int arabic) {
            var thousandsMagnitude = arabic >= 1000 ? (arabic % 10000) / 1000 : 0;
            var hundredsMagnitude = arabic >= 100 ? (arabic % 1000) / 100 : 0;
            var tensMagnitude = arabic >= 10 ? (arabic % 100) / 10 : 0;
            var onesMagnitude = arabic > 0 ? (arabic % 10) : 0;

            var roman = String.Format(
                "{0}{1}{2}{3}",
                thousands.getSymbol(thousandsMagnitude),
                hundreds.getSymbol(hundredsMagnitude),
                tens.getSymbol(tensMagnitude),
                ones.getSymbol(onesMagnitude)
            );
            return roman;
        }
    }

    class SymbolPattern {
        private string onesSymbol;
        private string fivesSymbol;
        private string tensSymbol;

        public SymbolPattern(
            string onesSymbol,
            string fivesSymbol = null,
            string tensSymbol = null
        ) {
            this.onesSymbol = onesSymbol;
            this.fivesSymbol = fivesSymbol;
            this.tensSymbol = tensSymbol;
        }

        public string getSymbol(int value) {
            switch (value) {
                case 1: return String.Format("{0}", onesSymbol);
                case 2: return String.Format("{0}{0}", onesSymbol);
                case 3: return String.Format("{0}{0}{0}", onesSymbol);

                case 4:
                    if (fivesSymbol != null) {
                        return String.Format("{0}{1}", onesSymbol, fivesSymbol);
                    }
                    break;

                case 5:
                    if (fivesSymbol != null) {
                        return String.Format("{0}", fivesSymbol);
                    }
                    break;

                case 6:
                    if (fivesSymbol != null) {
                        return String.Format("{0}{1}", fivesSymbol, onesSymbol);
                    }
                    break;

                case 7:
                    if (fivesSymbol != null) {
                        return String.Format("{0}{1}{1}", fivesSymbol, onesSymbol);
                    }
                    break;

                case 8:
                    if (fivesSymbol != null) {
                        return String.Format("{0}{1}{1}{1}", fivesSymbol, onesSymbol);
                    }
                    break;

                case 9:
                    if (! (fivesSymbol == null || tensSymbol == null)) {
                        return String.Format("{0}{1}", onesSymbol, tensSymbol);
                    }
                    break;

                default:
                    return "";
            }

            return "";
        }
    }
}
