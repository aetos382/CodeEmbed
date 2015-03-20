namespace CodeEmbed.GitHubClient.Serialization.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    [ContractClassFor(typeof(IJsonSerializer))]
    public abstract class JsonSerializerContract :
        IJsonSerializer
    {
        public Task<T> Deserialize<T>(
            TextReader reader,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(reader != null);

            throw new NotImplementedException();
        }
    }
}
