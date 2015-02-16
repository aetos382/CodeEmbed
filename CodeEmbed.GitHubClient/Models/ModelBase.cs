namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Network;

    public abstract class ModelBase
    {
        private readonly IConnection _connection;

        public ModelBase(IConnection connection)
        {
            this._connection = connection;
        }

        public IConnection Connection
        {
            get
            {
                return this._connection;
            }
        }
    }
}
