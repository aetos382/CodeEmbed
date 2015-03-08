using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    interface IRepository
    {
        string Name { get; }

        IRepositoryUser User { get; }

        IRepository Parent { get; }
    }
}
