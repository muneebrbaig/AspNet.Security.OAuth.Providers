﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System;
using AspNet.Security.OAuth.Nylas;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Authentication;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods to add Nylas authentication capabilities to an HTTP application pipeline.
    /// </summary>
    public static class NylasAuthenticationExtensions
    {
        /// <summary>
        /// Adds <see cref="NylasAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Nylas authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static AuthenticationBuilder AddNylas([NotNull] this AuthenticationBuilder builder)
        {
            return builder.AddNylas(NylasAuthenticationDefaults.AuthenticationScheme, options => { });
        }

        /// <summary>
        /// Adds <see cref="NylasAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Nylas authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="configuration">The delegate used to configure the OpenID 2.0 options.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static AuthenticationBuilder AddNylas(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] Action<NylasAuthenticationOptions> configuration)
        {
            return builder.AddNylas(NylasAuthenticationDefaults.AuthenticationScheme, configuration);
        }

        /// <summary>
        /// Adds <see cref="NylasAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Nylas authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="configuration">The delegate used to configure the Nylas options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddNylas(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] string scheme,
            [NotNull] Action<NylasAuthenticationOptions> configuration)
        {
            return builder.AddNylas(scheme, NylasAuthenticationDefaults.DisplayName, configuration);
        }

        /// <summary>
        /// Adds <see cref="NylasAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Nylas authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="caption">The optional display name associated with this instance.</param>
        /// <param name="configuration">The delegate used to configure the Nylas options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddNylas(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] string scheme,
            [CanBeNull] string caption,
            [NotNull] Action<NylasAuthenticationOptions> configuration)
        {
            return builder.AddOAuth<NylasAuthenticationOptions, NylasAuthenticationHandler>(scheme, caption, configuration);
        }
    }
}