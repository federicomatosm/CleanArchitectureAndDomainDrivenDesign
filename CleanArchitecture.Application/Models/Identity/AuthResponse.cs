using System;
namespace CleanArchitecture.Application.Models.Identity
{
	public class AuthResponse
	{
        public string Id { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Emiail { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}

