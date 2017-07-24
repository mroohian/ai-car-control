using AICore.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AICore.Tests.Utilities
{
    [TestClass]
    public class CryptoRandomTest
    {
        [TestMethod]
        public void TestGenerateRandom()
        {
            for (int i = 0; i < 1000; i++)
            {
                var newParam = new CryptoRandom().RandomValue;

                Assert.IsTrue(newParam <= 1.0);
                Assert.IsTrue(newParam >= -1.0);
            }
        }
    }
}
