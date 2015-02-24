namespace DeserializeTest
{
    using System;
    using System.Linq;

    public class RepositoryUser :
        IRepositoryUser<Foo>
    {
        private readonly IRepositoryUser<IFoo> _user;

        private readonly Foo _foo;

        public RepositoryUser(IRepositoryUser<IFoo> user)
        {
            this._user = user;
            this._foo = new Foo(user.Foo);
        }

        public string Name
        {
            get
            {
                return this._user.Name;
            }
        }

        public Foo Foo
        {
            get
            {
                return this._foo;
            }
        }
    }
}
