namespace CodeEmbed.Web.Http.Formatting
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Formatting;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;

    public class PlaintextMediaTypeFormatter :
        MediaTypeFormatter
    {
        private const int DefaultBufferSize = 1024;

        public PlaintextMediaTypeFormatter()
        {
            this.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/plain"));
            this.SupportedEncodings.Add(Encoding.UTF8);
            this.SupportedEncodings.Add(Encoding.Unicode);
        }

        public override bool CanReadType(Type type)
        {
            return type == typeof(string);
        }

        public override bool CanWriteType(Type type)
        {
            return type == typeof(string);
        }

        public override async Task<object> ReadFromStreamAsync(
            Type type,
            Stream readStream,
            HttpContent content,
            IFormatterLogger formatterLogger)
        {
            var encoding = this.SelectCharacterEncoding(content.Headers);

            using (var reader = new StreamReader(readStream, encoding, true, DefaultBufferSize, true))
            {
                string result = await reader.ReadToEndAsync().ConfigureAwait(false);
                return result;
            }
        }

        public override async Task WriteToStreamAsync(
            Type type,
            object value,
            Stream writeStream,
            HttpContent content,
            TransportContext transportContext)
        {
            var encoding = this.SelectCharacterEncoding(content.Headers);

            using (var writer = new StreamWriter(writeStream, encoding, DefaultBufferSize, true))
            {
                await writer.WriteAsync((string)value);
            }
        }
    }
}
