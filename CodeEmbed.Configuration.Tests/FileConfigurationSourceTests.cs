namespace CodeEmbed.Configuration.Tests
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FileConfigurationSourceTests
    {
        public FileConfigurationSourceTests()
        {
        }

        public TestContext TestContext { get; set; }

        [TestMethod]
        [DeploymentItem(@"TestData\config.json", "TestData")]
        public void 正常()
        {
            string path = Path.Combine(this.TestContext.DeploymentDirectory, @"TestData\config.json");

            var config = new FileConfigurationSource(path);

            string actual = config.Values["value1"];

            Assert.AreEqual("hoge", actual);
        }

        [TestMethod]
        public void ファイルが無くてもコンストラクターは例外を投げない()
        {
            new FileConfigurationSource("notfound.json");
        }

        [TestMethod]
        public void 不正なファイル名でもコンストラクターは例外を投げない()
        {
            new FileConfigurationSource("???<><><>.json");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void ディレクトリがない場合に例外を投げる()
        {
            new FileConfigurationSource(@"notfound\config.json", true);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void ファイルがない場合に例外を投げるオプション()
        {
            new FileConfigurationSource("notfound.json", true);
        }
    }
}
