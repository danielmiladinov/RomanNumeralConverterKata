using System;
using System.Collections.Generic;

namespace RomanNumerals.Converter {

    public class RomanNumeralConverter {
        private Dictionary<char, int> symbols;

        public RomanNumeralConverter() {
            symbols = new Dictionary<char, int> {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
            };
        }

        public int convert(string numeral) {
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
    }
}
