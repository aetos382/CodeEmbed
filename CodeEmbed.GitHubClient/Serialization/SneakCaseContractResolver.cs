namespace CodeEmbed.GitHubClient.Serialization
{
    using System;
    using System.Linq;
    using System.Text;

    using Newtonsoft.Json.Serialization;

    public class SneakCaseContractResolver :
        DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            var builder = new StringBuilder();

            foreach (char c in propertyName)
            {
                if (char.IsUpper(c))
                {
                    if (builder.Length > 0)
                    {
                        builder.Append("_");
                    }

                    builder.Append(char.ToLowerInvariant(c));
                }
                else
                {
                    builder.Append(c);
                }
            }

            return builder.ToString();
        }
    }
}
