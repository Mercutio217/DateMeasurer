using NUnit.Framework;

namespace DateMeasureTest
{
    [TestFixture]
    public class ValidatorTests
    {
        private Validator testValidator;
        
        [Test]
        public void TestIfValidatorChecksValidDate()
        {
            testValidator = new Validator();
            Assert.True(testValidator.Validate("15.05.2001"));

        }
    }
}