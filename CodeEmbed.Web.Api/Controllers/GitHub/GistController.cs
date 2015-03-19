namespace CodeEmbed.Web.Api.Controllers.GitHub
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web.Http;

    using CodeEmbed.GitHubClient;
    using CodeEmbed.GitHubClient.Models;
    using CodeEmbed.Web.Http;

    [RoutePrefix("github-gist/{id}")]
    public class GistController : ApiController
    {
        [Route("{filename}")]
        public async Task<HttpResponseMessage> GetGistCode(
            string id,
            string fileName)
        {
            var client = GitHubUtility.GetClient();

            HttpResponseMessage response;

            try
            {
                string code = await client.GetGistCode(id, fileName);
                response = this.Plaintext(code);
            }
            catch (GitHubNotFoundException ex)
            {
                response = this.Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                response = this.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

            return response;
        }

        [Route("{version}/{filename}")]
        public async Task<HttpResponseMessage> GetGistCode(
            string id,
            string version,
            string fileName)
        {
            var client = GitHubUtility.GetClient();

            HttpResponseMessage response;

            try
            {
                string code = await client.GetGistCode(id, version, fileName);
                response = this.Plaintext(code);
            }
            catch (GitHubNotFoundException ex)
            {
                response = this.Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                response = this.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

            return response;
        }
    }
}
