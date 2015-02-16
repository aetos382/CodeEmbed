namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class ModelBase
    {
        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client;

        protected ModelBase(IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(client != null);

            this._client = client;
        }

        public IGitHubClient Client
        {
            [Pure]
            get
            {
                Contract.Ensures(Contract.Result<IGitHubClient>() != null);

                return this._client;
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [ContractInvariantMethod]
        [DebuggerStepThrough]
        [DebuggerHidden]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._client != null);
        }
    }
}
