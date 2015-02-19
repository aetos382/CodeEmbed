











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
	[DebuggerStepThrough]
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
	using System.Diagnostics;
	using System.Diagnostics.Contracts;

	using Newtonsoft.Json;
	
	using CodeEmbed.GitHubClient.Models;

	[GeneratedCode("SerializableClass.tt", "1.0")]
	[DebuggerStepThrough]
	[JsonObject]
	public class SerializableRepositoryGenerated :
		IRepositoryGenerated
	{
		[ContractPublicPropertyName("Name")]
		private readonly string _name;
		[ContractPublicPropertyName("Uri")]
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
	[DebuggerStepThrough]
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
	using System.Diagnostics;
	using System.Diagnostics.Contracts;

	using Newtonsoft.Json;
	
	using CodeEmbed.GitHubClient.Models.Internal;

	[GeneratedCode("SerializableClass.tt", "1.0")]
	[DebuggerStepThrough]
	[JsonObject]
	public class SerializableRepositoryUserGenerated :
		IRepositoryUserGenerated
	{
		[ContractPublicPropertyName("Name")]
		private readonly string _name;
		[ContractPublicPropertyName("Uri")]
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
	public interface IFooGenerated
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
	[DebuggerStepThrough]
	public class FooGenerated :
		RepositoryUserGenerated,
		IFooGenerated
	{
		private readonly IFooGenerated _foo;

		public FooGenerated(
			IFooGenerated foo)
			: base(
				foo)
		{
			Contract.Requires<ArgumentNullException>(foo != null);

			this._foo = foo;
		}

		public string Hoge
		{
			get
			{
				return this._foo.Hoge;
			}
		}

        [Conditional("CONTRACTS_FULL")]
        [DebuggerStepThrough]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._foo != null);
        }
	}
}







namespace CodeEmbed.GitHubClient.Models.Serialization
{
	using System;
	using System.CodeDom.Compiler;
	using System.Diagnostics;
	using System.Diagnostics.Contracts;

	using Newtonsoft.Json;
	
	using CodeEmbed.GitHubClient.Models.Internal;

	[GeneratedCode("SerializableClass.tt", "1.0")]
	[DebuggerStepThrough]
	[JsonObject]
	public class SerializableFooGenerated :
		SerializableRepositoryUserGenerated,
		IFooGenerated
	{
		[ContractPublicPropertyName("Hoge")]
		private readonly string _hoge;

		[JsonConstructor]
		public SerializableFooGenerated(
			string name,
			string uri,
			string hoge)
			: base(
				name,
				uri)
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







namespace CodeEmbed.GitHubClient.Models
{
	using System;
	using System.CodeDom.Compiler;
	using System.Diagnostics.Contracts;
	
	[GeneratedCode("ModelInterface.tt", "1.0")]
	public interface IBarGenerated
		: IFooGenerated
	{
		// hige
		string Hige { [Pure] get; }

	}
}







namespace CodeEmbed.GitHubClient.Models
{
	using System;
	using System.CodeDom.Compiler;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Diagnostics.Contracts;
	
	[GeneratedCode("ModelClass.tt", "1.0")]
	[DebuggerStepThrough]
	public class BarGenerated :
		FooGenerated,
		IBarGenerated
	{
		private readonly IBarGenerated _bar;

		public BarGenerated(
			IBarGenerated bar)
			: base(
				bar)
		{
			Contract.Requires<ArgumentNullException>(bar != null);

			this._bar = bar;
		}

		public string Hige
		{
			get
			{
				return this._bar.Hige;
			}
		}

        [Conditional("CONTRACTS_FULL")]
        [DebuggerStepThrough]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._bar != null);
        }
	}
}







namespace CodeEmbed.GitHubClient.Models.Serialization
{
	using System;
	using System.CodeDom.Compiler;
	using System.Diagnostics;
	using System.Diagnostics.Contracts;

	using Newtonsoft.Json;
	
	using CodeEmbed.GitHubClient.Models;

	[GeneratedCode("SerializableClass.tt", "1.0")]
	[DebuggerStepThrough]
	[JsonObject]
	public class SerializableBarGenerated :
		SerializableFooGenerated,
		IBarGenerated
	{
		[ContractPublicPropertyName("Hige")]
		private readonly string _hige;

		[JsonConstructor]
		public SerializableBarGenerated(
			string name,
			string uri,
			string hoge,
			string hige)
			: base(
				name,
				uri,
				hoge)
		{
			this._hige = hige;
		}

		[JsonProperty("hige")]
		public string Hige
		{
			get
			{
				return this._hige;
			}
		}

	}
}


