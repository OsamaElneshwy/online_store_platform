using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Owin.Security.OAuth;

namespace SWE2.DbContext
{
    public class MyAuthorizationServerProvider : OAuthAuthorizationServerProvider
        {
            public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
            {
                context.Validated();
            }

            public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
            {
                using (ApplicationUserRepository _repo = new ApplicationUserRepository())
                {
                    var user = _repo.ValidateUser(context.UserName, context.Password);
                    if (user == null)
                    {
                        context.SetError("invalid_grant", "Provided username and password is incorrect");
                        return;
                    }

                    var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                    identity.AddClaim(new Claim(ClaimTypes.Role, user.Role));
                    identity.AddClaim(new Claim("Email", user.Email));
                    context.Validated(identity);
                }
            }

        }
    }