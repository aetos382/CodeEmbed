namespace CodeEmbed.GitHubClient.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json.Converters;

    public class CamelCaseStringEnumConverter :
        StringEnumConverter
    {
        public CamelCaseStringEnumConverter()
        {
            this.CamelCaseText = true;
        }
    }
}
