using RomanNumerals.Converter;
using NUnit.Framework;

namespace RomanNumerals.Test {

    [TestFixture]
    public class RNCTest {

        [Test]
        public void shouldReturnZeroWhenGivenBadInput() {
            var c = new RomanNumeralConverter();
            Assert.AreEqual(0, c.convert("BAD"));
        }

        [Test]
        public void shouldReturn1WhenGivenI() {
            var c = new RomanNumeralConverter();
            Assert.AreEqual(1, c.convert("I"));
        }

        [Test]
        public void shouldReturn2WhenGivenII() {
            var c = new RomanNumeralConverter();
            Assert.AreEqual(2, c.convert("II"));
        }
    }
}