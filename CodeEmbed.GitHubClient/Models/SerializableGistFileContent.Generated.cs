








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
	public partial class SerializableGistFileContent :
		SerializableGistFile,
		IGistFileContent
	{
		[ContractPublicPropertyName("Content")]
		private readonly String _content;

		/// <summary>Create new instance of SerializableGistFileContent.</summary>
		[JsonConstructor]
		public SerializableGistFileContent(
			Int64 size,
			Uri rawUri,
			String contentType,
			Boolean truncated,
			String language,
			String content)
			: base(
				size,
				rawUri,
				contentType,
				truncated,
				language)
		{

			this._content = content;
		}

		/// <summary>Map to "content"</summary>
		[JsonProperty("content")]
		public String Content
		{
			get
			{
				return this._content;
			}
		}
	}
}
