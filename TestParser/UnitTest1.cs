using GoogleAppVersionParser.Service;

namespace TestParser
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetStringContent()
        {
            var result = GoogleAppVersionParserService.GetTextVersionAsync("").GetAwaiter().GetResult();
            Assert.IsFalse(String.IsNullOrEmpty(result));
        }
    }
}