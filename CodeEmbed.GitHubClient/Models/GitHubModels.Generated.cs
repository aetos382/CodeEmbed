









namespace CodeEmbed.GitHubClient.Models
{
	using System;
	using System.CodeDom.Compiler;
	using System.Diagnostics.Contracts;
	
	[GeneratedCode("ModelInterface.tt", "1.0")]
	public interface IRepositoryGenerated
	{
		// name
		string Name { [Pure] get; }

		// url
		string Uri { [Pure] get; }

	}
}






namespace CodeEmbed.GitHubClient.Models
{
	using System;
	using System.CodeDom.Compiler;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Diagnostics.Contracts;
	
	using CodeEmbed.GitHubClient;

	[GeneratedCode("ModelClass.tt", "1.0")]
	public class RepositoryGenerated :
		IRepositoryGenerated
	{
		[ContractPublicPropertyName("Client")]
		private readonly IGitHubClient _client;

		private readonly IRepositoryGenerated _repository;

		public RepositoryGenerated(
			IGitHubClient client,
			IRepositoryGenerated repository)
		{
			Contract.Requires<ArgumentNullException>(client != null);
			Contract.Requires<ArgumentNullException>(repository != null);

			this._client = client;
			this._repository = repository;
		}

		public IGitHubClient Client
		{
			get
			{
				Contract.Ensures(Contract.Result<IGitHubClient>() != null);

				return this._client;
			}
		}

		public string Name
		{
			get
			{
				return this._repository.Name;
			}
		}

		public string Uri
		{
			get
			{
				return this._repository.Uri;
			}
		}

        [Conditional("CONTRACTS_FULL")]
        [DebuggerStepThrough]
        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
			Contract.Invariant(this._client != null);
            Contract.Invariant(this._repository != null);
        }
	}
}






namespace CodeEmbed.GitHubClient.Models.Serialization
{
	using System;
	using System.CodeDom.Compiler;

	using Newtonsoft.Json;
	
	using CodeEmbed.GitHubClient.Models;

	[GeneratedCode("SerializableClass.tt", "1.0")]
	[JsonObject]
	public class SerializableRepositoryGenerated :
		IRepositoryGenerated
	{
		private readonly string _name;
		private readonly string _uri;

		[JsonConstructor]
		public SerializableRepositoryGenerated(
			string name,
			string uri)
		{
			this._name = name;
			this._uri = uri;
		}

		[JsonProperty("name")]
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		[JsonProperty("url")]
		public string Uri
		{
			get
			{
				return this._uri;
			}
		}

	}
}





namespace CodeEmbed.GitHubClient.Models.Internal
{
	using System;
	using System.CodeDom.Compiler;
	using System.Diagnostics.Contracts;
	
	[GeneratedCode("ModelInterface.tt", "1.0")]
	public interface IRepositoryUserGenerated
	{
		// name
		string Name { [Pure] get; }

		// url
		string Uri { [Pure] get; }

	}
}






namespace CodeEmbed.GitHubClient.Models.Internal
{
	using System;
	using System.CodeDom.Compiler;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Diagnostics.Contracts;
	
	[GeneratedCode("ModelClass.tt", "1.0")]
	public class RepositoryUserGenerated :
		IRepositoryUserGenerated
	{
		private readonly IRepositoryUserGenerated _repositoryUser;

		public RepositoryUserGenerated(
			IRepositoryUserGenerated repositoryUser)
		{
			Contract.Requires<ArgumentNullException>(repositoryUser != null);

			this._repositoryUser = repositoryUser;
		}

		public string Name
		{
			get
			{
				return this._repositoryUser.Name;
			}
		}

		public string Uri
		{
			get
			{
				return this._repositoryUser.Uri;
			}
		}

        [Conditional("CONTRACTS_FULL")]
        [DebuggerStepThrough]
        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._repositoryUser != null);
        }
	}
}






namespace CodeEmbed.GitHubClient.Models.Serialization
{
	using System;
	using System.CodeDom.Compiler;

	using Newtonsoft.Json;
	
	using CodeEmbed.GitHubClient.Models.Internal;

	[GeneratedCode("SerializableClass.tt", "1.0")]
	[JsonObject]
	public class SerializableRepositoryUserGenerated :
		IRepositoryUserGenerated
	{
		private readonly string _name;
		private readonly string _uri;

		[JsonConstructor]
		public SerializableRepositoryUserGenerated(
			string name,
			string uri)
		{
			this._name = name;
			this._uri = uri;
		}

		[JsonProperty("name")]
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		[JsonProperty("url")]
		public string Uri
		{
			get
			{
				return this._uri;
			}
		}

	}
}





namespace CodeEmbed.GitHubClient.Models
{
	using System;
	using System.CodeDom.Compiler;
	using System.Diagnostics.Contracts;
	
	using CodeEmbed.GitHubClient.Models.Internal;

	[GeneratedCode("ModelInterface.tt", "1.0")]
	public interface IDetailedUserGenerated
		: IRepositoryUserGenerated
	{
		// hoge
		string Hoge { [Pure] get; }

	}
}






namespace CodeEmbed.GitHubClient.Models
{
	using System;
	using System.CodeDom.Compiler;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Diagnostics.Contracts;
	
	using CodeEmbed.GitHubClient.Models.Internal;

	[GeneratedCode("ModelClass.tt", "1.0")]
	public class DetailedUserGenerated :
		RepositoryUserGenerated,
		IDetailedUserGenerated
	{
		private readonly IDetailedUserGenerated _detailedUser;

		public DetailedUserGenerated(
			IDetailedUserGenerated detailedUser)
			: base(detailedUser)
		{
			Contract.Requires<ArgumentNullException>(detailedUser != null);

			this._detailedUser = detailedUser;
		}

		public string Hoge
		{
			get
			{
				return this._detailedUser.Hoge;
			}
		}

        [Conditional("CONTRACTS_FULL")]
        [DebuggerStepThrough]
        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._detailedUser != null);
        }
	}
}






namespace CodeEmbed.GitHubClient.Models.Serialization
{
	using System;
	using System.CodeDom.Compiler;

	using Newtonsoft.Json;
	
	using CodeEmbed.GitHubClient.Models.Internal;

	[GeneratedCode("SerializableClass.tt", "1.0")]
	[JsonObject]
	public class SerializableDetailedUserGenerated :
		SerializableRepositoryUserGenerated,
		IDetailedUserGenerated
	{
		private readonly string _hoge;

		[JsonConstructor]
		public SerializableDetailedUserGenerated(
			string hoge)
		{
			this._hoge = hoge;
		}

		[JsonProperty("hoge")]
		public string Hoge
		{
			get
			{
				return this._hoge;
			}
		}

	}
}


