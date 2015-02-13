namespace CodeEmbed.Configuration.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ConfigurationStoreTests
    {
        [TestMethod]
        public void 正常()
        {
            var mock = new MockConfigurationSource();
            mock.Values["baz"] = "BAZ";

            var store = new ConfigurationStore(mock);

            string actual = store.GetConfigurationValue("baz");

            Assert.AreEqual("BAZ", actual);
        }

        [TestMethod]
        public void 値がなければNullを返す()
        {
            var mock = new MockConfigurationSource();

            var store = new ConfigurationStore(mock);

            string actual = store.GetConfigurationValue("baz");

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void ConfigurationSourceがなければNullを返す()
        {
            var store = new ConfigurationStore();

            string actual = store.GetConfigurationValue("baz");

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void ConfigurationSourceの前にある方が優先()
        {
            var mock1 = new MockConfigurationSource();
            mock1.Values["baz"] = "BAZ1";

            var mock2 = new MockConfigurationSource();
            mock2.Values["baz"] = "BAZ2";

            var store = new ConfigurationStore(mock1, mock2);

            string actual = store.GetConfigurationValue("baz");

            Assert.AreEqual("BAZ1", actual);
        }
    }
}
