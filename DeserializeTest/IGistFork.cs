using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    interface IGistFork<out TRepositoryUser>
        where TRepositoryUser : IRepositoryUser
    {
        TRepositoryUser User { get; }
    }
}
