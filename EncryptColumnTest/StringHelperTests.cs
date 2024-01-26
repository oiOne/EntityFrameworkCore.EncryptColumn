using EntityFrameworkCore.EncryptColumn.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncryptColumnTest
{
    [TestClass]
    public class StringHelperTests
    {

        [TestMethod]
        public void Base63StringValidationCheck()
        {
            var email = "test.test@anydomain.com";
            var result = email.IsBase64String();
            Assert.IsFalse(result);
        }
    }
}
