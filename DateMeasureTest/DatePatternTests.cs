using DateMeasure;
using NUnit.Framework;

namespace DateMeasureTest
{
    [TestFixture]
    public class DatePatternTests
    {
        private DatePattern _testPattern;
        static DateSign _sign1 = new DateSign("12.01.2001");
        static DateSign _sign2 = new DateSign("13.04.2001");
        static DateSign _sign3 = new DateSign("13.04.2010");
        static DateSign _sign4 = new DateSign("14.01.2001");

        private readonly DateSign[] _testDateSignArray = new DateSign[] {_sign1, _sign2, _sign3, _sign4};

        [SetUp]
        public void InitializeDateSigns()
        {
            foreach (var sign in _testDateSignArray)
            {
                sign.SetConvertedDate();
                sign.SetSeparator();
            }
        }

        [Test]
        public void TestIfComparatorWorksProperlyWithSameYear()
        {
            _testPattern = new DatePattern(_sign1, _sign4);
            Assert.AreEqual("12 - 14.01.2001", _testPattern.GetRange());
        }

        [Test]
        public void TestIfComparatorWorksProperlyWithSameMonthAndDayButDifferenTYear()
        {
            _testPattern = new DatePattern(_sign1, _sign2);
            Assert.AreEqual("12.01 - 13.04.2001", _testPattern.GetRange());
        }

        [Test]
        public void TestIfComparatorWorksProperlyWithSameMonth()
        {
            _testPattern = new DatePattern(_sign2, _sign3);
            Assert.AreEqual("13.04.2001 - 13.04.2010", _testPattern.GetRange());
        }
    }
}