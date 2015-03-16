namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    using Newtonsoft.Json;

    [GeneratedCode("SerializableClass.tt", "1.0")]
    [DebuggerStepThrough]
    [JsonObject]
    public partial class SerializableGistChangeStatus :
        IGistChangeStatus
    {
        [ContractPublicPropertyName("Deletions")]
        private readonly Int32 _deletions;

        [ContractPublicPropertyName("Additions")]
        private readonly Int32 _additions;

        [ContractPublicPropertyName("Total")]
        private readonly Int32 _total;

        /// <summary>Create new instance of SerializableGistChangeStatus.</summary>
        [JsonConstructor]
        public SerializableGistChangeStatus(
            Int32 deletions,
            Int32 additions,
            Int32 total)
        {

            this._deletions = deletions;
            this._additions = additions;
            this._total = total;
        }

        /// <summary>Map to "deletions"</summary>
        [JsonProperty("deletions")]
        public Int32 Deletions
        {
            get
            {
                return this._deletions;
            }
        }

        /// <summary>Map to "additions"</summary>
        [JsonProperty("additions")]
        public Int32 Additions
        {
            get
            {
                return this._additions;
            }
        }

        /// <summary>Map to "total"</summary>
        [JsonProperty("total")]
        public Int32 Total
        {
            get
            {
                return this._total;
            }
        }
    }
}
