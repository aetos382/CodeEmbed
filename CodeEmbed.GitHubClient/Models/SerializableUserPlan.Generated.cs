








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
	public partial class SerializableUserPlan :
		IUserPlan
	{
		[ContractPublicPropertyName("Name")]
		private readonly String _name;

		[ContractPublicPropertyName("Space")]
		private readonly Int64 _space;

		[ContractPublicPropertyName("PrivateRepositories")]
		private readonly Int32 _privateRepositories;

		[ContractPublicPropertyName("Collaborators")]
		private readonly Int32 _collaborators;

		/// <summary>Create new instance of SerializableUserPlan.</summary>
		[JsonConstructor]
		public SerializableUserPlan(
			String name,
			Int64 space,
			Int32 privateRepositories,
			Int32 collaborators)
		{

			this._name = name;
			this._space = space;
			this._privateRepositories = privateRepositories;
			this._collaborators = collaborators;
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

		/// <summary>Map to "space"</summary>
		[JsonProperty("space")]
		public Int64 Space
		{
			get
			{
				return this._space;
			}
		}

		/// <summary>Map to "private_repos"</summary>
		[JsonProperty("private_repos")]
		public Int32 PrivateRepositories
		{
			get
			{
				return this._privateRepositories;
			}
		}

		/// <summary>Map to "collaborators"</summary>
		[JsonProperty("collaborators")]
		public Int32 Collaborators
		{
			get
			{
				return this._collaborators;
			}
		}
	}
}
