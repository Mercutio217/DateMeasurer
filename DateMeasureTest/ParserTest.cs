using System;
using NUnit.Framework;

namespace DateMeasureTest
{
    [TestFixture]
    internal class ParserTest
    {
        [Test]
        public void TestIfParserConvertsDMYFormatWithDotProperly()
        {
            var testString = "12.04.1994";
            var parser = DateTime.TryParse(testString, out DateTime result);
            Assert.AreEqual(result.ToShortDateString(), "12.04.1994");
        }
    }
}