/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System;

namespace AspNet.Security.OAuth.Nylas
{
    /// <summary>
    /// Contains constants specific to the <see cref="NylasAuthenticationHandler"/>.
    /// </summary>
    public static class NylasAuthenticationConstants
    {
        public static class Claims
        {
            public const string Id = "urn:nylas:id";
            public const string Name = "urn:nylas:name";
            public const string Email = "urn:nylas:email_address";
            public const string AccountId = "urn:nylas:account_id";
            public const string LinkedAt = "urn:nylas:linked_at";
            public const string Provider = "urn:nylas:provider";
        }
    }
}
