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

        [Test]
        public void shouldReturnZeroWhenGivenBadInput() {
            Assert.AreEqual(0, c.convert("BAD"));
        }

        [Test]
        public void shouldReturn1WhenGivenI() {
            Assert.AreEqual(1, c.convert("I"));
        }

        [Test]
        public void shouldReturn2WhenGivenII() {
            Assert.AreEqual(2, c.convert("II"));
        }

        [Test]
        public void shouldReturn3WhenGivenIII() {
            Assert.AreEqual(3, c.convert("III"));
        }

        [Test]
        public void shouldReturn4WhenGivenIV() {
            Assert.AreEqual(4, c.convert("IV"));
        }

        [Test]
        public void shouldReturn5WhenGivenV() {
            Assert.AreEqual(5, c.convert("V"));
        }

        [Test]
        public void shouldReturn6WhenGivenVI() {
            Assert.AreEqual(6, c.convert("VI"));
        }
    }
}