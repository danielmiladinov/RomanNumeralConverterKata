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
    }
}