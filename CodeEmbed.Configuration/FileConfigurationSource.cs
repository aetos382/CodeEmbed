namespace CodeEmbed.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    public class FileConfigurationSource :
        IConfigurationSource
    {
        [ContractPublicPropertyName("DefaultConfigurationFilePath")]
        private static string _defaultConfigurationFilePath = GetDefaultConfigurationPath();

        [ContractPublicPropertyName("FileMustExist")]
        private readonly bool _fileMustExist = false;

        [ContractPublicPropertyName("Values")]
        private IDictionary<string, string> _settings = new Dictionary<string, string>();

        [ContractPublicPropertyName("ConfigurationFilePath")]
        private string _configurationFilePath;

        public FileConfigurationSource()
            : this(DefaultConfigurationFilePath)
        {
        }

        public FileConfigurationSource(
            string configurationFilePath)
            : this(configurationFilePath, false)
        {
            Contract.Requires<ArgumentNullException>(configurationFilePath != null);
            Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(configurationFilePath));
        }

        public FileConfigurationSource(
            string configurationFilePath,
            bool fileMustExist)
        {
            Contract.Requires<ArgumentNullException>(configurationFilePath != null);
            Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(configurationFilePath));

            this._configurationFilePath = configurationFilePath;
            this._fileMustExist = fileMustExist;

            this.Refresh();
        }

        public static string DefaultConfigurationFilePath
        {
            [Pure]
            get
            {
                Contract.Ensures(Contract.Result<string>() != null);
                Contract.Ensures(!string.IsNullOrEmpty(Contract.Result<string>()));

                return _defaultConfigurationFilePath;
            }

            set
            {
                Contract.Requires<ArgumentNullException>(value != null);
                Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(value));

                _defaultConfigurationFilePath = value;
            }
        }

        public string ConfigurationFilePath
        {
            [Pure]
            get
            {
                Contract.Ensures(Contract.Result<string>() != null);
                Contract.Ensures(!string.IsNullOrEmpty(Contract.Result<string>()));

                return this._configurationFilePath;
            }

            set
            {
                Contract.Requires<ArgumentNullException>(value != null);
                Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(value));

                if (string.Equals(this._configurationFilePath, value, StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }

                this._configurationFilePath = value;

                this.Refresh();
            }
        }

        public bool FileMustExist
        {
            [Pure]
            get
            {
                return this._fileMustExist;
            }
        }

        public IDictionary<string, string> Values
        {
            get
            {
                return this._settings;
            }
        }

        public void Refresh()
        {
            this._settings.Clear();

            string json;

            try
            {
                json = File.ReadAllText(this._configurationFilePath);
            }
            catch
            {
                if (this._fileMustExist)
                {
                    throw;
                }

                return;
            }

            var settings = JsonConvert.DeserializeObject<IDictionary<string, string>>(json);
            if (settings != null)
            {
                this._settings = settings;
            }
        }

        [Pure]
        private static string GetDefaultConfigurationPath()
        {
            Contract.Ensures(Contract.Result<string>() != null);
            Contract.Ensures(!string.IsNullOrEmpty(Contract.Result<string>()));

            string dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = Path.Combine(dir, "CodeEmbed.config.json");

            return path;
        }

        [Conditional("CONTRACTS_FULL")]
        [ContractInvariantMethod]
        [DebuggerStepThrough]
        [DebuggerHidden]
        private void ObjectInvariant()
        {
            Contract.Invariant(_defaultConfigurationFilePath != null);
            Contract.Invariant(!string.IsNullOrEmpty(_defaultConfigurationFilePath));

            Contract.Invariant(this._configurationFilePath != null);
            Contract.Invariant(!string.IsNullOrEmpty(this._configurationFilePath));

            Contract.Invariant(this._settings != null);
        }
    }
}
