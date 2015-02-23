namespace DeserializeTest
{
    using System;
    using System.Linq;

    public interface IRepository<out TRepositoryUser>
        where TRepositoryUser : IRepositoryUser
    {
        int Id { get; }

        string Name { get; }

        TRepositoryUser User { get; }
    }
}
