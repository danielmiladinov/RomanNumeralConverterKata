using System;

namespace RomanNumerals.Converter {

    public class RomanNumeralConverter {
        public RomanNumeralConverter() {
        }

        public int convert(string numeral) {
            if (numeral == "I") {
                return 1;
            }
            return 0;
        }
    }
}

