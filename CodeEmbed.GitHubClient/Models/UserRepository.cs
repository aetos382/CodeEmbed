namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    using CodeEmbed.GitHubClient.Models.Internal;

    public class UserRepository :
        Repository,
        IUserRepository
    {
        private readonly IUserRepository _userRepository;

        public UserRepository(
            IUserRepository userRepository,
            IGitHubClient client)
            : base(userRepository, client)
        {
            Contract.Requires<ArgumentNullException>(userRepository != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._userRepository = userRepository;
        }

        public IRepositoryPermissions Permissions
        {
            get
            {
                return this._userRepository.Permissions;
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [ContractInvariantMethod]
        [DebuggerStepThrough]
        [DebuggerHidden]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._userRepository != null);
        }
    }
}
