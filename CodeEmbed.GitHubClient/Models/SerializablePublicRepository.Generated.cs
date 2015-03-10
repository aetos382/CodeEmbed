








namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    
    using Newtonsoft.Json;
    
	[GeneratedCode("SerializableClass.tt", "1.0")]
	[DebuggerStepThrough]
	[JsonObject]
	public partial class SerializablePublicRepository :
		IPublicRepository
	{
		[ContractPublicPropertyName("Id")]
		private readonly Int64 _id;

		[ContractPublicPropertyName("Owner")]
		private readonly IRepositoryUser _owner;

		[ContractPublicPropertyName("Name")]
		private readonly String _name;

		[ContractPublicPropertyName("FullName")]
		private readonly String _fullName;

		[ContractPublicPropertyName("Description")]
		private readonly String _description;

		[ContractPublicPropertyName("IsPrivate")]
		private readonly Boolean _isPrivate;

		[ContractPublicPropertyName("Fork")]
		private readonly Boolean _fork;

		[ContractPublicPropertyName("Uri")]
		private readonly Uri _uri;

		[ContractPublicPropertyName("HtmlUri")]
		private readonly Uri _htmlUri;

		/// <summary>Create new instance of SerializablePublicRepository.</summary>
		[JsonConstructor]
		public SerializablePublicRepository(
			Int64 id,
			IRepositoryUser owner,
			String name,
			String fullName,
			String description,
			Boolean isPrivate,
			Boolean fork,
			Uri uri,
			Uri htmlUri)
		{
			Contract.Requires<ArgumentNullException>(owner != null);
			Contract.Requires<ArgumentNullException>(name != null);

			this._id = id;
			this._owner = owner;
			this._name = name;
			this._fullName = fullName;
			this._description = description;
			this._isPrivate = isPrivate;
			this._fork = fork;
			this._uri = uri;
			this._htmlUri = htmlUri;
		}

		/// <summary>Map to "id"</summary>
		[JsonProperty("id")]
		public Int64 Id
		{
			get
			{
				return this._id;
			}
		}

		/// <summary>Map to "owner"</summary>
		[JsonProperty("owner")]
		public IRepositoryUser Owner
		{
			get
			{
				return this._owner;
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

		/// <summary>Map to "full_name"</summary>
		[JsonProperty("full_name")]
		public String FullName
		{
			get
			{
				return this._fullName;
			}
		}

		/// <summary>Map to "description"</summary>
		[JsonProperty("description")]
		public String Description
		{
			get
			{
				return this._description;
			}
		}

		/// <summary>Map to "private"</summary>
		[JsonProperty("private")]
		public Boolean IsPrivate
		{
			get
			{
				return this._isPrivate;
			}
		}

		/// <summary>Map to "fork"</summary>
		[JsonProperty("fork")]
		public Boolean Fork
		{
			get
			{
				return this._fork;
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

		/// <summary>Map to "html_url"</summary>
		[JsonProperty("html_url")]
		public Uri HtmlUri
		{
			get
			{
				return this._htmlUri;
			}
		}

		/// <summary>Specifies invariant contracts of object.</summary>
        [Conditional("CONTRACTS_FULL")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
			Contract.Invariant(this._owner != null);
			Contract.Invariant(this._name != null);
        }
	}
}
