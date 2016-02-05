using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

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
            var reversedNumerals = numeral.ToCharArray();
            Array.Reverse(reversedNumerals);

            var reversed = new List<char>();
            reversed.AddRange(reversedNumerals);

            var numeralInvalid = reversed.Aggregate(System.Tuple.Create<bool, int, char>(false, 1, ' '),
                (acc, nextChar) => {
                    if (acc.Item1) {
                        return acc;
                    } else {
                        var timesSameCharWasSeen = ((nextChar == acc.Item3) ? acc.Item2 + 1 : 1);
                        return System.Tuple.Create(
                            !symbols.ContainsKey(nextChar) || timesSameCharWasSeen > 3,
                            timesSameCharWasSeen,
                            nextChar
                        );
                    }
                }
            ).Item1;

            if (numeralInvalid) {
                return 0;
            }

            return reversed.Aggregate(System.Tuple.Create(0, 0), (acc, nextChar) => {
                var sumSoFar = acc.Item1;
                var prevValue = acc.Item2;
                var nextValue = symbols[nextChar];

                if (prevValue != 0 && prevValue > nextValue) {
                    sumSoFar -= nextValue;
                } else {
                    sumSoFar += nextValue;
                }

                prevValue = nextValue;
                return System.Tuple.Create(sumSoFar, nextValue);
            }).Item1;
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
        private Dictionary<int, string> symbolTable;

        public SymbolPattern(
            string onesSymbol,
            string fivesSymbol = null,
            string tensSymbol = null
        ) {
            symbolTable = new Dictionary<int, string> {
                {1, String.Format("{0}", onesSymbol)},
                {2, String.Format("{0}{0}", onesSymbol)},
                {3, String.Format("{0}{0}{0}", onesSymbol)},
                {4, (fivesSymbol != null) ? String.Format("{0}{1}", onesSymbol, fivesSymbol) : ""},
                {5, (fivesSymbol != null) ? String.Format("{0}", fivesSymbol) : ""},
                {6, (fivesSymbol != null) ? String.Format("{0}{1}", fivesSymbol, onesSymbol) : ""},
                {7, (fivesSymbol != null) ? String.Format("{0}{1}{1}", fivesSymbol, onesSymbol) : ""},
                {8, (fivesSymbol != null) ? String.Format("{0}{1}{1}{1}", fivesSymbol, onesSymbol) : ""},
                {9, (! (fivesSymbol == null || tensSymbol == null)) ? String.Format("{0}{1}", onesSymbol, tensSymbol) : ""},
            };
        }

        public string getSymbol(int value) {
            if (symbolTable.ContainsKey(value)) {
                return symbolTable[value];
            } else {
                return "";
            }
        }
    }
}
