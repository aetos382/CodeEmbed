using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    using Newtonsoft.Json;

    abstract class SerializableGistBase :
        IGistBase
    {
        private readonly string _id;

        protected SerializableGistBase(string id)
        {
            this._id = id;
        }

        public string Id
        {
            get
            {
                return this._id;
            }
        }
    }
}
