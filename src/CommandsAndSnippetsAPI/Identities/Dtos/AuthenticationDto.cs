using Microsoft.AspNetCore.Identity;

namespace CommandsAndSnippetsAPI.Dtos.User
{
    public sealed class AuthenticationDto
    {
        public string Token { get; set; }
        
        public IdentityResult IdentityResult { get; set; }
    }
}