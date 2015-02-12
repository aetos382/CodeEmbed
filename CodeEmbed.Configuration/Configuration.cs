namespace CodeEmbed.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Configuration
    {
        public ConfigurationLayer AvailableLayer { get; set; }

        private string _userConfigurationFile;

        public string UserConfigurationFile
        {
            get
            {
                return this._userConfigurationFile;
            }

            set
            {
                this._userConfigurationFile = value;
            }
        }

        public string GetConfigurationValue(string valueName)
        {
            
        }
    }
}
