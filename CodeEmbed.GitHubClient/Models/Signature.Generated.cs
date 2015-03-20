namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    using CodeEmbed.GitHubClient;

    [GeneratedCode("ModelClass.tt", "1.0")]
    [DebuggerStepThrough]
    public partial class Signature :
        ISignature
    {
        private readonly ISignature _signature = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of Signature.</summary>
        public Signature(
            ISignature signature,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(signature != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._signature = signature;

            this._client = client;
        }

        /// <summary>Map to "date"</summary>
        public DateTime Date
        {
            get
            {
                return this._signature.Date;
            }
        }

        /// <summary>Map to "name"</summary>
        public String Name
        {
            get
            {
                return this._signature.Name;
            }
        }

        /// <summary>Map to "email"</summary>
        public String Email
        {
            get
            {
                return this._signature.Email;
            }
        }

        public IGitHubClient Client
        {
            get
            {
                Contract.Ensures(Contract.Result<IGitHubClient>() != null);

                return this._client;
            }
        }

        /// <summary>Specifies invariant contracts of object.</summary>
        [Conditional("CONTRACTS_FULL")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._signature != null);
            Contract.Invariant(this._client != null);
        }
    }
}
