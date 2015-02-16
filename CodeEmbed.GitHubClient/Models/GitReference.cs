namespace CodeEmbed.GitHubClient.Models
{
    //// GET /repos/:owner/:repo/git/refs[/:ref]

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models.Internal;
    using CodeEmbed.GitHubClient.Network;

    public class GitReference :
        IGitReference
    {
        private readonly IConnection _connection;

        private readonly IGitReference _reference;

        public GitReference(
            IConnection connection,
            IGitReference reference)
        {
            this._connection = connection;
            this._reference = reference;
        }

        public string Ref
        {
            get
            {
                return this._reference.Ref;
            }
        }

        public Uri Url
        {
            get
            {
                return this._reference.Url;
            }
        }

        IGitRefObject IGitReference.Object
        {
            get
            {
                return this._reference.Object;
            }
        }
    }
}
