namespace CodeEmbed.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.Configuration.Contracts;

    [ContractClass(typeof(ConfigurationSourceContracts))]
    public interface IConfigurationSource
    {
        IDictionary<string, string> Values { get; }

        void Refresh();
    }
}
