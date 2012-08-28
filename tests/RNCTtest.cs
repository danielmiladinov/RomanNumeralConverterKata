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
            };
        }
    }
}