using IdentityServer4;
using IdentityServer4.Models;

namespace INFNET.Spotfy.IdP.IdentityConfiguration
{
    public class IdentityConfiguration
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>()
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }

        public static IEnumerable<ApiResource> GetApiResource()
        {
            return new List<ApiResource>()
            {
                new ApiResource("SpotifyLite", "Infnet Arquitetura - Leonardo", new string[] { "user", "admin" })
                {
                    ApiSecrets =
                    {
                        new Secret("MeAprovaRafael".Sha256())
                    },
                    Scopes =
                    {
                        "SpotifyApi"
                    }
                }
            };
        }

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                new ApiScope
                {
                    Name = "SpotifyAPI",
                    Description = "Scope for API spotify",
                    UserClaims = {"user" , "admin"}
                }
            };
        }

        public static IEnumerable<Client> GetClientes()
        {
            return new List<Client>
            {
                new Client()
                {
                    ClientId = "",
                    ClientName = "",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    ClientSecrets = { new Secret("MeAprovaRafael".Sha256())},
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "SpotifyAPI"
                    }
                }
            };
        }
    }
}
