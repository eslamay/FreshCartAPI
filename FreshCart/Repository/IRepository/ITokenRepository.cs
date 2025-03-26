﻿using Microsoft.AspNetCore.Identity;

namespace FreshCart.Repository.IRepository
{
	public interface ITokenRepository
	{
		string CreateJWTToken(IdentityUser user, List<string> roles);
	}
}
