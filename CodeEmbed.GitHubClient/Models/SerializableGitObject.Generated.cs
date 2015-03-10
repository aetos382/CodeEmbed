








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
	public partial class SerializableGitObject :
		IGitObject
	{
		[ContractPublicPropertyName("ObjectType")]
		private readonly String _objectType;

		[ContractPublicPropertyName("Hash")]
		private readonly String _hash;

		[ContractPublicPropertyName("Uri")]
		private readonly Uri _uri;

		/// <summary>Create new instance of SerializableGitObject.</summary>
		[JsonConstructor]
		public SerializableGitObject(
			String objectType,
			String hash,
			Uri uri)
		{

			this._objectType = objectType;
			this._hash = hash;
			this._uri = uri;
		}

		/// <summary>Map to "type"</summary>
		[JsonProperty("type")]
		public String ObjectType
		{
			get
			{
				return this._objectType;
			}
		}

		/// <summary>Map to "sha"</summary>
		[JsonProperty("sha")]
		public String Hash
		{
			get
			{
				return this._hash;
			}
		}

		/// <summary>Map to "url"</summary>
		[JsonProperty("url")]
		public Uri Uri
		{
			get
			{
				return this._uri;
			}
		}
	}
}
