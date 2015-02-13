namespace CodeEmbed.Configuration.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class MockConfigurationSource :
        IConfigurationSource
    {
        [ContractPublicPropertyName("Values")]
        private readonly IDictionary<string, string> _settings = new Dictionary<string, string>();

        public IDictionary<string, string> Values
        {
            get
            {
                return this._settings;
            }
        }

        public void Refresh()
        {
        }
    }
}
