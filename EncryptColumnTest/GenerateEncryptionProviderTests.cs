using EntityFrameworkCore.EncryptColumn.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncryptColumnTest
{
    [TestClass]
    public class GenerateEncryptionProviderTests
    {
        [TestMethod]
        public void TryToDecodeInvalidBase64String()
        {
            var decodeString = "test.test@anydomain.com";

            var provider = new GenerateEncryptionProvider("dDoo44fa12SW97ru");
            var result = provider.Decrypt(decodeString);

            Assert.IsNotNull(result);
            Assert.AreEqual(decodeString, result);
        }
    }
}
