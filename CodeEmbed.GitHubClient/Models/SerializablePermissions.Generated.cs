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
    public partial class SerializablePermissions :
        IPermissions
    {
        [ContractPublicPropertyName("Administration")]
        private readonly Boolean _administration;

        [ContractPublicPropertyName("Push")]
        private readonly Boolean _push;

        [ContractPublicPropertyName("Pull")]
        private readonly Boolean _pull;

        /// <summary>Create new instance of SerializablePermissions.</summary>
        [JsonConstructor]
        public SerializablePermissions(
            Boolean administration,
            Boolean push,
            Boolean pull)
        {

            this._administration = administration;
            this._push = push;
            this._pull = pull;
        }

        /// <summary>Map to "admin"</summary>
        [JsonProperty("admin")]
        public Boolean Administration
        {
            get
            {
                return this._administration;
            }
        }

        /// <summary>Map to "push"</summary>
        [JsonProperty("push")]
        public Boolean Push
        {
            get
            {
                return this._push;
            }
        }

        /// <summary>Map to "pull"</summary>
        [JsonProperty("pull")]
        public Boolean Pull
        {
            get
            {
                return this._pull;
            }
        }
    }
}
