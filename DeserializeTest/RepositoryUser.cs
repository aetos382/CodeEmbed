namespace DeserializeTest
{
    using System;
    using System.Linq;

    public class RepositoryUser :
        IRepositoryUser
    {
        private readonly IRepositoryUser _user;

        public RepositoryUser(IRepositoryUser user)
        {
            this._user = user;
        }

        public string Name
        {
            get
            {
                return this._user.Name;
            }
        }
    }
}
