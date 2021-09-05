/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System.Security.Claims;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;

namespace AspNet.Security.OAuth.Nylas
{
    /// <summary>
    /// Defines a set of options used by <see cref="NylasAuthenticationHandler"/>.
    /// </summary>
    public class NylasAuthenticationOptions : OAuthOptions
    {
        public NylasAuthenticationOptions()
        {
            ClaimsIssuer = NylasAuthenticationDefaults.Issuer;
            CallbackPath = NylasAuthenticationDefaults.CallbackPath;

            AuthorizationEndpoint = NylasAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = NylasAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = NylasAuthenticationDefaults.UserInformationEndpoint;

            ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "id");
            ClaimActions.MapJsonKey(ClaimTypes.Name, "name");
            ClaimActions.MapJsonKey(ClaimTypes.Email, "email_address");

            /*ClaimActions.MapJsonKey(ClaimTypes.Email, "account_id");
            ClaimActions.MapJsonKey(ClaimTypes.Email, "linked_at");
            ClaimActions.MapJsonKey(ClaimTypes.Email, "provider");*/
        }
    }
}
