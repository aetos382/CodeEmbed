








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
	

	[GeneratedCode("ModelClass.tt", "1.0")]
	public class RepositoryGenerated :
		IRepositoryGenerated
	{
		private readonly IRepositoryGenerated _repository;

		public RepositoryGenerated(
			IRepositoryGenerated repository)
		{
			this._repository = repository;
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


