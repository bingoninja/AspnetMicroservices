using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer
{
    public class Config
    {
        public static IEnumerable<Client> Clients =>
        new Client[]
        {
            new Client {
                ClientId = "catalog.api",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets =
                {
                    new Secret("secret".Sha256()) //TODO -- update this placeholder code
                },
                AllowedScopes = { "catalog.api"}
            }
        };
        public static IEnumerable<ApiScope> ApiScopes =>
         new ApiScope[]
         {
            new ApiScope("catalog.api", "Catalog API"),
            new ApiScope("basket.api", "Basket API"),
            new ApiScope("ordering.api", "Ordering API"),
            new ApiScope("discount.api", "Discount API")
         };
        public static IEnumerable<ApiResource> ApiResources =>
         new ApiResource[]
         {
         };
        public static IEnumerable<IdentityResource> IdentityResources =>
         new IdentityResource[]
         {
         };
        public static List<TestUser> TestUsers =>
         new List<TestUser>
         {
         };
    }
}