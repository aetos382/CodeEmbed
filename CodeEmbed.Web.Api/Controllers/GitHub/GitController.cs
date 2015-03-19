namespace CodeEmbed.Web.Api.Controllers.GitHub
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web.Http;

    using CodeEmbed.GitHubClient;
    using CodeEmbed.Web.Http;

    [RoutePrefix("github-git/{user}/{repository}")]
    public class GitController :
        ApiController
    {
        [Route("{*path}")]
        public async Task<HttpResponseMessage> GetGitCode(
            string user,
            string repository,
            string path)
        {
            var client = GitHubUtility.GetClient();

            HttpResponseMessage response;

            try
            {
                string code = await client.GetGitCode(user, repository, path);

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

        [Route("branches/{branch}/{*path}")]
        public async Task<HttpResponseMessage> GetGitCodeByBranch(
            string user,
            string repository,
            string branch,
            string path)
        {
            var client = GitHubUtility.GetClient();

            HttpResponseMessage response;

            try
            {
                string code = await client.GetGitCodeFromBranch(user, repository, branch, path);

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

        [Route("tags/{tag}/{*path}")]
        public async Task<HttpResponseMessage> GetGitCodeByTag(
            string user,
            string repository,
            string tag,
            string path)
        {
            var client = GitHubUtility.GetClient();

            HttpResponseMessage response;

            try
            {
                string code = await client.GetGitCodeFromTag(user, repository, tag, path);

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

        [Route("commits/{commit}/{*path}")]
        public async Task<HttpResponseMessage> GetGitCodeByCommit(
            string user,
            string repository,
            string commit,
            string path)
        {
            var client = GitHubUtility.GetClient();

            HttpResponseMessage response;

            try
            {
                string code = await client.GetGitCodeFromCommit(user, repository, commit, path);

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
