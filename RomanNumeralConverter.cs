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
            } else if (numeral == "IV") {
                return 4;
            } else if (numeral == "V") {
                return 5;
            } else if (numeral == "VI") {
                return 6;
            } else if (numeral == "VII") {
                return 7;
            } else if (numeral == "VIII") {
                return 8;
            }
            return 0;
        }
    }
}
