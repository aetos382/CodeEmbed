namespace CodeEmbed.GitHubClient.Models
{
    //// GET /repos/:owner/:repo/branches[/:branch]
    
    using System;
    using System.Linq;
    using System.Runtime.Serialization;

    [DataContract]
    public class Branch
    {
        private readonly IBranch _branch;

        public Branch(
            IBranch branch)
        {
            this._branch = branch;
        }

        [DataMember]
        public string Name
        {
            get
            {
                return this._branch.Name;
            }
        }
    }
}
