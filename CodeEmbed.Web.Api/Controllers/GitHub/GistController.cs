namespace CodeEmbed.Web.Api.Controllers.GitHub
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web.Http;

    using CodeEmbed.Web.Http;

    using Octokit;

    [RoutePrefix("github-gist/{id}")]
    public class GistController : ApiController
    {
        [Route("{filename}")]
        public async Task<HttpResponseMessage> GetGistCode(
            string id,
            string filename)
        {
            var client = GitHubUtility.GetClient();

            HttpResponseMessage response;

            try
            {
                var gist = await client.Gist.Get(id);

                GistFile file;
                if (gist.Files.TryGetValue(filename, out file))
                {
                    response = this.PlainText(file.Content);
                }
                else
                {
                    response = this.Request.CreateErrorResponse(HttpStatusCode.NotFound, "file not found.");
                }
            }
            catch (NotFoundException ex)
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
