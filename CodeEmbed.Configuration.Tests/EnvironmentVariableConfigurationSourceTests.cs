namespace CodeEmbed.Configuration.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EnvironmentVariableConfigurationSourceTests
    {
        [TestMethod]
        public void 正常()
        {
            Environment.SetEnvironmentVariable("bar", "BAR");

            var source = new EnvironmentVariableConfigurationSource();

            string actual = source.Values["bar"];

            Assert.AreEqual("BAR", actual);
        }
    }
}
