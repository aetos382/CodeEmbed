namespace CodeEmbed.Web.Http
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web.Http;

    using CodeEmbed.Web.Http.Formatting;

    public static class ApiControllerExtension
    {
        public static HttpResponseMessage PlainText(
            this ApiController controller,
            string text)
        {
            Contract.Requires<ArgumentNullException>(controller != null);

            return PlainText(controller, text, Encoding.UTF8);
        }

        public static HttpResponseMessage PlainText(
            this ApiController controller,
            string text,
            Encoding encoding)
        {
            Contract.Requires<ArgumentNullException>(controller != null);
            Contract.Requires<ArgumentNullException>(encoding != null);

            var contentType = new MediaTypeHeaderValue("text/plain");
            contentType.CharSet = encoding.HeaderName;

            var response = controller.Request.CreateResponse(
                HttpStatusCode.OK, text, new PlainTextMediaTypeFormatter(), contentType);

            return response;
        }
    }
}
