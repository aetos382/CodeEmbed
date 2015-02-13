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

    using CodeEmbed.Contracts;

    using Newtonsoft.Json;

    public class FileConfigurationSource :
        IConfigurationSource
    {
        [ContractPublicPropertyName("DefaultConfigurationFilePath")]
        private static string _defaultConfigurationFilePath = GetDefaultConfigurationPath();

        [ContractPublicPropertyName("Values")]
        private IDictionary<string, string> _settings = new Dictionary<string, string>();

        [ContractPublicPropertyName("ConfigurationFilePath")]
        private string _configurationFilePath;

        [ContractPublicPropertyName("FileMustExist")]
        private readonly bool _fileMustExist = false;

        public FileConfigurationSource()
            : this(DefaultConfigurationFilePath)
        {
        }

        public FileConfigurationSource(
            string configurationFilePath)
            : this(configurationFilePath, false)
        {
            Requires.StringNotNullOrEmpty(configurationFilePath);
        }

        public FileConfigurationSource(
            string configurationFilePath,
            bool fileMustExist)
        {
            Requires.StringNotNullOrEmpty(configurationFilePath);

            this._configurationFilePath = configurationFilePath;
            this._fileMustExist = fileMustExist;

            this.Refresh();
        }

        public static string DefaultConfigurationFilePath
        {
            set
            {
                Requires.StringNotNullOrEmpty(value);

                _defaultConfigurationFilePath = value;
            }

            [Pure]
            get
            {
                Ensures.StringIsNotNullOrEmpty();

                return _defaultConfigurationFilePath;
            }
        }

        public string ConfigurationFilePath
        {
            [Pure]
            get
            {
                Ensures.StringIsNotNullOrEmpty();

                return this._configurationFilePath;
            }

            set
            {
                Requires.StringNotNullOrEmpty(value);

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
            Ensures.StringIsNotNullOrEmpty();

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
