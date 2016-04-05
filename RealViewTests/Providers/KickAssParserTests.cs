using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealView.Providers.KickAss;

namespace RealView.Providers.Tests
{
    [TestClass()]
    public class KickAssParserTests
    {
        [TestMethod()]
        public void ParseTest()
        {
            KickAssParser parser = new KickAssParser();

            string data = "";
            var set = parser.Compose(data);

            Assert.AreEqual(25, set.ResourceList.Count);
        }
    }
}