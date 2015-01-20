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

    using CodeEmbed.Web.Http;

    using Octokit;

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
                var repo = await client.Repository.Get(user, repository);

                response = await this.GetGitCodeByBranch(user, repository, repo.DefaultBranch, path);
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
                var bra = await client.Repository.GetBranch(user, repository, branch);

                response = await this.GetGitCodeByCommit(user, repository, bra.Commit.Sha, path);
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
                var tg = await client.Repository.GetAllTags(user, repository);
                var t = tg.SingleOrDefault(x => x.Name == tag);

                if (t == null)
                {
                    response = this.Request.CreateErrorResponse(HttpStatusCode.NotFound, "path not found");
                    return response;
                }

                response = await this.GetGitCodeByCommit(user, repository, t.Commit.Sha, path);
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
                var com = await client.Repository.Commits.Get(user, repository, commit);

                var tree = await client.GitDatabase.Tree.Get(user, repository, com.Commit.Tree.Sha);

                var names = path.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                string blobHash = null;

                foreach (var name in names)
                {
                    var node = tree.Tree.SingleOrDefault(x => x.Path == name);
                    if (node == null)
                    {
                        response = this.Request.CreateErrorResponse(HttpStatusCode.NotFound, "path not found");
                        return response;
                    }

                    if (node.Type == TreeType.Blob)
                    {
                        blobHash = node.Sha;
                        break;
                    }

                    tree = await client.GitDatabase.Tree.Get(user, repository, node.Sha);
                }

                if (blobHash == null)
                {
                    response = this.Request.CreateErrorResponse(HttpStatusCode.NotFound, "path not found");
                    return response;
                }

                var blob = await client.GitDatabase.Blob.Get(user, repository, blobHash);

                string content;

                if (blob.Encoding == EncodingType.Base64)
                {
                    var data = Convert.FromBase64String(blob.Content);

                    var encoding = (Encoding)Encoding.UTF8.Clone();
                    encoding.EncoderFallback = new EncoderExceptionFallback();
                    encoding.DecoderFallback = new DecoderExceptionFallback();

                    content = encoding.GetString(data);
                }
                else if (blob.Encoding == EncodingType.Utf8)
                {
                    content = blob.Content;
                }
                else
                {
                    throw new NotSupportedException(string.Format("blob.encoding = {0}", blob.Encoding));
                }

                response = this.PlainText(content);
            }
            catch (NotFoundException ex)
            {
                response = this.Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
            catch (DecoderFallbackException ex)
            {
                response = this.Request.CreateErrorResponse(HttpStatusCode.Forbidden, ex);
            }
            catch (EncoderFallbackException ex)
            {
                response = this.Request.CreateErrorResponse(HttpStatusCode.Forbidden, ex);
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
