﻿namespace CodeEmbed.GitHubClient
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

        public static Uri Branch(
            string repositoryFullName,
            string branch)
        {
            Contract.Requires<ArgumentNullException>(repositoryFullName != null);
            Contract.Requires<ArgumentNullException>(branch != null);

            Contract.Ensures(Contract.Result<Uri>() != null);

            string relUriString = string.Format(
                CultureInfo.InvariantCulture, "/repos/{0}/branches/{1}", repositoryFullName, branch);

            var relUri = new Uri(relUriString, UriKind.Relative);

            return relUri;
        }

        public static Uri References(
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

        public static Uri Reference(
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

        public static Uri BranchReference(
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

        public static Uri TagReference(
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

        public static Uri BranchReferences(
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

        public static Uri TagReference(
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
