using NUnit.Framework;
using DateMeasure;

namespace DateMeasureTest
{
    [TestFixture]
    public class DateSignTests
    {
        private DateSign _testDateSign;

        [Test]
        public void TestIfDateSignConvertsDateProperly()
        {
            _testDateSign = new DateSign("12/04/1999");
            Assert.True(_testDateSign.SetConvertedDate());
        }

        [Test]
        public void TestIfDateSignGetsSignProperly1()
        {
            _testDateSign = new DateSign("14/11/1991");
            _testDateSign.SetSeparator();
            Assert.AreEqual("/", _testDateSign.Separator);
        }
        
        [Test]
        public void TestIfDateSignGetsSignProperly2()
        {
            _testDateSign = new DateSign("14-11-1991");
            _testDateSign.SetSeparator();
            Assert.AreEqual("-", _testDateSign.Separator);
        }
        
        
        
    }
}