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
            Assert.AreEqual(result.ToShortDateString(), "12/04/1994");
        }
        
        [Test]
        public void TestIfParserConvertsDMYFormatWithDashProperly()
        {
            var testString = "12-04-1994";
            var parser = DateTime.TryParse(testString, out DateTime result);
            Assert.AreEqual(result.ToShortDateString(), "12.04.1994");
        }
        
        [Test]
        public void TestIfParserConvertsDMYFormatWithSlashProperly()
        {
            var testString = "12/04/1994";
            var parser = DateTime.TryParse(testString, out DateTime result);
            Assert.AreEqual(result.ToShortDateString(), "12.04.1994");
        }
        
        [Test]
        public void TestIfParserConvertsYMDFormatWithDotProperly()
        {
            var testString = "1994.04.12";
            var parser = DateTime.TryParse(testString, out DateTime result);
            Assert.AreEqual(result.ToShortDateString(), "12.04.1994");
        }
        
        [Test]
        public void TestIfParserConvertsYMDFormatWithDashProperly()
        {
            var testString = "1994-04-12";
            var parser = DateTime.TryParse(testString, out DateTime result);
            Assert.AreEqual(result.ToShortDateString(), "12.04.1994");
        }
        
        [Test]
        public void TestIfParserConvertsYMDFormatWithSlashProperly()
        {
            var testString = "1994/04/12";
            var parser = DateTime.TryParse(testString, out DateTime result);
            Assert.AreEqual(result.ToShortDateString(), "12.04.1994");
        }
        
        [Test]
        public void TestIfParserConvertsMDYFormatWithDotProperly()
        {
            var testString = "04.13.1994";
            var parser = DateTime.TryParse(testString, out DateTime result);
//            Assert.AreEqual(result.ToShortDateString(), "13.04.1994");
            Assert.True(parser);
        }
        
        [Test]
        public void TestIfParserConvertsMDYFormatWithDashProperly()
        {
            var testString = "04-13-1994";
            var parser = DateTime.TryParse(testString, out DateTime result);
            Assert.AreEqual(result.ToShortDateString(), "13.04.1994");
        }
        
        [Test]
        public void TestIfParserConvertsMDYFormatWithSlashProperly()
        {
            var testString = "04/13/1994";
            var parser = DateTime.TryParse(testString, out DateTime result);
            Assert.AreEqual(result.ToShortDateString(), "13.04.1994");
        }
    }
}