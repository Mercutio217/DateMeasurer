using DateMeasure;
using NUnit.Framework;

namespace DateMeasureTest
{
    [TestFixture]
    public class ValidatorTests
    {
        private Validator _testValidator;
        
        [Test]
        public void TestIfValidatorChecksValidDate()
        {
            _testValidator = new Validator("15.05.2001");
            Assert.True(_testValidator.Validate());

        }
        
        [Test]
        public void TestIfValidatorChecksInValidDate()
        {
            _testValidator = new Validator("45.05.-1");
            Assert.False(_testValidator.Validate());

        }
    }
}