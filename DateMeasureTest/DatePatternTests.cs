using DateMeasure;
using NUnit.Framework;

namespace DateMeasureTest
{
    [TestFixture]
    public class DatePatternTests
    {
        private DatePattern _testPattern;
        static DateSign sign1 = new DateSign("12.01.2001");
        static DateSign sign2 = new DateSign("12.02.2001");
        static DateSign sign3 = new DateSign("13.04.2001");
        static DateSign sign4 = new DateSign("13.04.2010");
        static DateSign sign5 = new DateSign("20.01.1983");
        static DateSign sign6 = new DateSign("30.02.2001");
        private DateSign[] _testDateSignArray = new DateSign[] {sign1, sign2, sign3, sign4, sign5, sign6};

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
        public void TestIfComparatorWorksProperly()
        {

            _testPattern = new DatePattern();
        }
    }
}