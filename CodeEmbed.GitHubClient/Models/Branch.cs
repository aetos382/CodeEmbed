namespace CodeEmbed.GitHubClient.Models
{
    //// GET /repos/:owner/:repo/branches[/:branch]
    
    using System;
    using System.Linq;

    public class Branch :
        IBranch
    {
        private readonly IBranch _branch;

        public Branch(
            IBranch branch)
        {
            this._branch = branch;
        }

        public string Name
        {
            get
            {
                return this._branch.Name;
            }
        }
    }
}
