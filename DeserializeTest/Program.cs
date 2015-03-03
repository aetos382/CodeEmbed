using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = Client.GetRepository();

            var gistSummary = Client.GetGistSummary();
            var gist = Client.GetGist();
        }
    }
}
