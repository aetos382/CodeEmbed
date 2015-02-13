namespace CodeEmbed.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EnvironmentVariableConfigurationSource :
        IConfigurationSource
    {
        [ContractPublicPropertyName("Values")]
        private readonly IDictionary<string, string> _settings = new Dictionary<string, string>();

        private readonly EnvironmentVariableTarget _target;

        public EnvironmentVariableConfigurationSource()
            : this(EnvironmentVariableTarget.Process)
        {
        }

        public EnvironmentVariableConfigurationSource(
            EnvironmentVariableTarget target)
        {
            this._target = target;

            this.Refresh();
        }

        public IDictionary<string, string> Values
        {
            get
            {
                return this._settings;
            }
        }

        public EnvironmentVariableTarget Target
        {
            get
            {
                return this._target;
            }
        }

        public void Refresh()
        {
            this._settings.Clear();

            foreach (string key in Environment.GetEnvironmentVariables().Keys)
            {
                this._settings[key] = Environment.GetEnvironmentVariable(key, this._target);
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [ContractInvariantMethod]
        [DebuggerStepThrough]
        [DebuggerHidden]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._settings != null);
        }
    }
}
