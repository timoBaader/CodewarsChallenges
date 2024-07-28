using NUnit.Framework;
using static Codewars.Challenges;

namespace Codewars.Tests
{
    [TestFixture]
    public class PigIt
    {
        [TestCase("Pig latin is cool", "igPay atinlay siay oolcay")]
        [TestCase("Hello world !", "elloHay orldway !")]
        public void PigIt_ReturnsCorrectResult(string input, string expected)
        {
            string result = PigIt(input);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
