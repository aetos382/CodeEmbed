namespace CodeEmbed.Configuration.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AppSettingsConfigurationSourceTests
    {
        [TestMethod]
        public void 正常()
        {
            var source = new AppSettingsConfigurationSource();

            string actual = source.Values["foo"];

            Assert.AreEqual("FOO", actual);
        }
    }
}
