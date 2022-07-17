using IdentityModel;
using IdentityServer4.Validation;
using INFNET.Spotfy.Domain.Repository;

namespace INFNET.Spotfy.IdP.GrantTypesValidator
{
    public class CustomPasswordValidator : IResourceOwnerPasswordValidator
    {
        public CustomPasswordValidator(IUsuarioRepository repository)
        {
            Repository = repository;
        }

        public IUsuarioRepository Repository { get; set; }

        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            var password = context.Password;
            var username = context.UserName;

            var user = await Repository.GetUserByCredencial(username, password);

            if (user != null)
                context.Result = new GrantValidationResult(user.Id.ToString(), OidcConstants.AuthenticationMethods.Password);
        }
    }
}
