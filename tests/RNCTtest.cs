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
            };
        }
    }
}