using System;

namespace RomanNumerals.Converter {

    public class RomanNumeralConverter {
        public RomanNumeralConverter() {
        }

        public int convert(string numeral) {
            if (numeral == "I") {
                return 1;
            } else if (numeral == "II") {
                return 2;
            } else if (numeral == "III") {
                return 3;
            }
            return 0;
        }
    }
}

