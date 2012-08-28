using RomanNumerals.Converter;
using NUnit.Framework;

namespace RomanNumerals.Test {

    [TestFixture]
    public class RNCTest {
        private RomanNumeralConverter c;

        [SetUp]
        public void setUp() {
            c = new RomanNumeralConverter();
        }

        [TestCaseSource("getRomanAndArabicPairs")]
        public void shouldReturnTheExpectedOutputGivenTheProvidedInput(string providedInput, int expectedOutput) {
            Assert.AreEqual(expectedOutput, c.convert(providedInput));
        }

        public object[] getRomanAndArabicPairs() {
            return new object[] {
                new object[] {"BAD", 0,},
                new object[] {"I", 1,},
                new object[] {"II", 2,},
                new object[] {"III", 3,},
                new object[] {"IV", 4,},
                new object[] {"V", 5,},
                new object[] {"VI", 6,},
                new object[] {"VII", 7,},
                new object[] {"VIII", 8,},
                new object[] {"IX", 9,},
                new object[] {"X", 10,},
                new object[] {"XI", 11,},
                new object[] {"XII", 12,},
                new object[] {"XIII", 13,},
                new object[] {"XIV", 14,},
                new object[] {"XV", 15,},
                new object[] {"XVI", 16,},
                new object[] {"XVII", 17,},
                new object[] {"XVIII", 18,},
                new object[] {"XIX", 19,},
                new object[] {"XX", 20,},
                new object[] {"XXI", 21,},
                new object[] {"XXII", 22,},
                new object[] {"XXIII", 23,},
                new object[] {"XXIV", 24,},
                new object[] {"XXV", 25,},
                new object[] {"XXVI", 26,},
                new object[] {"XXVII", 27,},
                new object[] {"XXVIII", 28,},
                new object[] {"XXIX", 29,},
                new object[] {"XXX", 30,},
                new object[] {"XXXI", 31,},
                new object[] {"XXXII", 32,},
                new object[] {"XXXIII", 33,},
                new object[] {"XXXIV", 34,},
                new object[] {"XXXV", 35,},
                new object[] {"XXXVI", 36,},
                new object[] {"XXXVII", 37,},
                new object[] {"XXXVIII", 38,},
                new object[] {"XXXIX", 39,},
                new object[] {"XXXX", 0,},
                new object[] {"XL", 40,},
                new object[] {"XLI", 41,},
                new object[] {"XLII", 42,},
                new object[] {"XLIII", 43,},
                new object[] {"XLIV", 44,},
                new object[] {"XLV", 45,},
                new object[] {"XLVI", 46,},
                new object[] {"XLVII", 47,},
                new object[] {"XLVIII", 48,},
                new object[] {"XLIX", 49,},
                new object[] {"L", 50,},
                new object[] {"LI", 51,},
                new object[] {"LII", 52,},
                new object[] {"LIII", 53,},
                new object[] {"LIV", 54,},
                new object[] {"LV", 55,},
                new object[] {"LVI", 56,},
                new object[] {"LVII", 57,},
                new object[] {"LVIII", 58,},
                new object[] {"LIX", 59,},
                new object[] {"LX", 60,},
                new object[] {"LXI", 61,},
                new object[] {"LXII", 62,},
                new object[] {"LXIII", 63,},
                new object[] {"LXIV", 64,},
                new object[] {"LXV", 65,},
                new object[] {"LXVI", 66,},
                new object[] {"LXVII", 67,},
                new object[] {"LXVIII", 68,},
                new object[] {"LXIX", 69,},
                new object[] {"LXX", 70,},
                new object[] {"LXXI", 71,},
                new object[] {"LXXII", 72,},
                new object[] {"LXXIII", 73,},
                new object[] {"LXXIV", 74,},
                new object[] {"LXXV", 75,},
                new object[] {"LXXVI", 76,},
                new object[] {"LXXVII", 77,},
                new object[] {"LXXVIII", 78,},
                new object[] {"LXXIX", 79,},
                new object[] {"LXXX", 80,},
                new object[] {"LXXXI", 81,},
                new object[] {"LXXXII", 82,},
                new object[] {"LXXXIII", 83,},
                new object[] {"LXXXIV", 84,},
                new object[] {"LXXXV", 85,},
                new object[] {"LXXXVI", 86,},
                new object[] {"LXXXVII", 87,},
                new object[] {"LXXXVIII", 88,},
                new object[] {"LXXXIX", 89,},
                new object[] {"XC", 90,},
            };
        }
    }
}
