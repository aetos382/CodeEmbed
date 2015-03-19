namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal static class GitHubUri
    {
        public static Uri Repository(
            string user,
            string repository)
        {
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);

            Contract.Ensures(Contract.Result<Uri>() != null);

            string relUriString = string.Format(
                CultureInfo.InvariantCulture, "/repos/{0}/{1}", user, repository);

            var relUri = new Uri(relUriString, UriKind.Relative);

            return relUri;
        }

        public static Uri Branch(
            string user,
            string repository,
            string branch)
        {
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(branch != null);

            Contract.Ensures(Contract.Result<Uri>() != null);

            string relUriString = string.Format(
                CultureInfo.InvariantCulture, "/repos/{0}/{1}/branches/{2}", user, repository, branch);

            var relUri = new Uri(relUriString, UriKind.Relative);

            return relUri;
        }

        public static Uri GitReferences(
            string user,
            string repository)
        {
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);

            Contract.Ensures(Contract.Result<Uri>() != null);

            string relUriString = string.Format(
                CultureInfo.InvariantCulture, "/repos/{0}/{1}/git/refs", user, repository);

            var relUri = new Uri(relUriString, UriKind.Relative);

            return relUri;
        }

        public static Uri GitReference(
            string user,
            string repository,
            string reference)
        {
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(reference != null);

            Contract.Ensures(Contract.Result<Uri>() != null);

            string relUriString = string.Format(
                CultureInfo.InvariantCulture, "/repos/{0}/{1}/git/refs/{2}", user, repository, reference);

            var relUri = new Uri(relUriString, UriKind.Relative);

            return relUri;
        }

        public static Uri GitBranchReferenece(
            string user,
            string repository,
            string branch)
        {
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(branch != null);

            Contract.Ensures(Contract.Result<Uri>() != null);

            string relUriString = string.Format(
                CultureInfo.InvariantCulture, "/repos/{0}/{1}/git/refs/heads/{2}", user, repository, branch);

            var relUri = new Uri(relUriString, UriKind.Relative);

            return relUri;
        }

        public static Uri GitTagReference(
            string user,
            string repository,
            string tag)
        {
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(tag != null);

            Contract.Ensures(Contract.Result<Uri>() != null);

            string relUriString = string.Format(
                CultureInfo.InvariantCulture, "/repos/{0}/{1}/git/refs/tags/{2}", user, repository, tag);

            var relUri = new Uri(relUriString, UriKind.Relative);

            return relUri;
        }

        public static Uri GitTag(
            string user,
            string repository,
            string tag)
        {
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(tag != null);

            Contract.Ensures(Contract.Result<Uri>() != null);

            string relUriString = string.Format(
                CultureInfo.InvariantCulture, "/repos/{0}/{1}/git/tags/{2}", user, repository, tag);

            var relUri = new Uri(relUriString, UriKind.Relative);

            return relUri;
        }

        public static Uri GitBranches(
            string user,
            string repository)
        {
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);

            Contract.Ensures(Contract.Result<Uri>() != null);

            string relUriString = string.Format(
                CultureInfo.InvariantCulture, "/repos/{0}/{1}/git/refs/heads", user, repository);

            var relUri = new Uri(relUriString, UriKind.Relative);

            return relUri;
        }

        public static Uri GitTags(
            string user,
            string repository)
        {
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);

            Contract.Ensures(Contract.Result<Uri>() != null);

            string relUriString = string.Format(
                CultureInfo.InvariantCulture, "/repos/{0}/{1}/git/refs/tags", user, repository);

            var relUri = new Uri(relUriString, UriKind.Relative);

            return relUri;
        }

        public static Uri GitCommit(
            string user,
            string repository,
            string commit)
        {
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(commit != null);

            Contract.Ensures(Contract.Result<Uri>() != null);

            string relUriString = string.Format(
                CultureInfo.InvariantCulture, "/repos/{0}/{1}/git/commits/{2}", user, repository, commit);

            var relUri = new Uri(relUriString, UriKind.Relative);

            return relUri;
        }

        public static Uri GitTree(
            string user,
            string repository,
            string tree,
            bool recursive)
        {
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(tree != null);

            Contract.Ensures(Contract.Result<Uri>() != null);

            string relUriString = string.Format(
                CultureInfo.InvariantCulture, "/repos/{0}/{1}/git/trees/{2}?recursive={3}", user, repository, tree, Convert.ToInt32(recursive));

            var relUri = new Uri(relUriString, UriKind.Relative);

            return relUri;
        }

        public static Uri GitBlob(
            string user,
            string repository,
            string blob)
        {
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(blob != null);

            Contract.Ensures(Contract.Result<Uri>() != null);

            string relUriString = string.Format(
                CultureInfo.InvariantCulture, "/repos/{0}/{1}/git/blobs/{2}", user, repository, blob);

            var relUri = new Uri(relUriString, UriKind.Relative);

            return relUri;
        }

        public static Uri Gist(
            string id)
        {
            Contract.Requires<ArgumentNullException>(id != null);

            Contract.Ensures(Contract.Result<Uri>() != null);

            string relUriString = string.Format(
                CultureInfo.InvariantCulture, "/gists/{0}", id);

            var relUri = new Uri(relUriString, UriKind.Relative);

            return relUri;
        }
    }
}
