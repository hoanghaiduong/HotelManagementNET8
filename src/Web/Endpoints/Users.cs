﻿
using MyWebApi.Infrastructure.Identity;

namespace MyWebApi.Web.Endpoints;

public class Users : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup("identity").MapIdentityApi<ApplicationUser>().AllowAnonymous();
    }
}
