namespace CodeEmbed.GitHubClient.JsonNet.Tests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class JsonNetSerializerTests
    {
        [TestMethod]
        public async Task Hoge()
        {
            const string json = "{ \"name\": \"Alice\" }";

            byte[] jsonBytes = Encoding.UTF8.GetBytes(json);
            using (var stream = new MemoryStream(jsonBytes))
            {
                var serializer = new JsonNetSerializer();
                var result = await serializer.Deserialize<IModel>(stream, Encoding.UTF8, CancellationToken.None);

                Assert.AreEqual("Alice", result.Name);
            }
        }
    }
}
