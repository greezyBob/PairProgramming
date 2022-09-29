using MoneyDispenserApp;

namespace RomanNumeralsTests2
{
    public class Tests
    {

        [Test]
        public void Given1_ReturnRoman1()
        {
            string result = "I";
            Assert.That(Program.Convert(1),Is.EqualTo(result));
        }
        [Test]
        public void Given3_ReturnRoman3()
        {
            string result = "III";
            Assert.That(Program.Convert(3), Is.EqualTo(result));
        }
        [Test]
        public void Given5_ReturnRoman5()
        {
            string result = "V";
            Assert.That(Program.Convert(5), Is.EqualTo(result));
        }
        [Test]
        public void Given8_ReturnRoman8()
        {
            string result = "VIII";
            Assert.That(Program.Convert(8), Is.EqualTo(result));
        }
        [Test]
        public void Given4_ReturnRoman4()
        {
            string result = "IV";
            Assert.That(Program.Convert(4), Is.EqualTo(result));
        }
        [Test]
        public void Given1999_ReturnRoman1999()
        {
            string result = "MCMXCIX";
            Assert.That(Program.Convert(1999), Is.EqualTo(result));
        }
        [Test]
        public void GivenNegativeNumber_ReturnArgumentOutOfRangeException()
        {
            Assert.That(() => Program.Convert(-1), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Dont be an idiot"));
        }
        [Test]
        public void Given0_ReturnArgumentOutOfRangeException()
        {
            Assert.That(() => Program.Convert(0), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Dont be an idiot"));
        }
    }
}