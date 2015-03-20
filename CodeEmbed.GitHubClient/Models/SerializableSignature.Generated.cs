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
    public partial class SerializableSignature :
        ISignature
    {
        [ContractPublicPropertyName("Date")]
        private readonly DateTime _date;

        [ContractPublicPropertyName("Name")]
        private readonly String _name;

        [ContractPublicPropertyName("Email")]
        private readonly String _email;

        /// <summary>Create new instance of SerializableSignature.</summary>
        [JsonConstructor]
        public SerializableSignature(
            DateTime date,
            String name,
            String email)
        {

            this._date = date;
            this._name = name;
            this._email = email;
        }

        /// <summary>Map to "date"</summary>
        [JsonProperty("date")]
        public DateTime Date
        {
            get
            {
                return this._date;
            }
        }

        /// <summary>Map to "name"</summary>
        [JsonProperty("name")]
        public String Name
        {
            get
            {
                return this._name;
            }
        }

        /// <summary>Map to "email"</summary>
        [JsonProperty("email")]
        public String Email
        {
            get
            {
                return this._email;
            }
        }
    }
}
