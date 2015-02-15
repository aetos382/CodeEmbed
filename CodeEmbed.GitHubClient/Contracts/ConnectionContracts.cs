namespace CodeEmbed.GitHubClient.Contracts
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ContractClassFor(typeof(IConnection))]
    public abstract class ConnectionContracts :
        IConnection
    {
        [DebuggerHidden]
        public Uri BaseUri
        {
            [Pure]
            get
            {
                Contract.Ensures(Contract.Result<Uri>() != null);

                throw new NotImplementedException();
            }
        }
    }
}
