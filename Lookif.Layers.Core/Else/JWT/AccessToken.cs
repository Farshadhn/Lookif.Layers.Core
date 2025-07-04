﻿using System;
using System.IdentityModel.Tokens.Jwt;

namespace Lookif.Layers.Core.Else.JWT;

public class AccessToken
{
    public string access_token { get; set; }
    public string refresh_token { get; set; }
    public string token_type { get; set; }
    public int expires_in { get; set; }
    public AccessToken()
    {

    }
    public AccessToken(JwtSecurityToken securityToken)
    {
        access_token = new JwtSecurityTokenHandler().WriteToken(securityToken);
        token_type = "Bearer";
        expires_in = (int)(securityToken.ValidTo - DateTime.Now).TotalSeconds;
    }
}