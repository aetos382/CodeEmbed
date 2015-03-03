using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    interface IRepository<out TRepository, out TRepositoryUser>
        where TRepository : IRepository<TRepository, TRepositoryUser>
        where TRepositoryUser : IRepositoryUser
    {
        string Name { get; }

        TRepositoryUser User { get; }

        TRepository Parent { get; }
    }
}
