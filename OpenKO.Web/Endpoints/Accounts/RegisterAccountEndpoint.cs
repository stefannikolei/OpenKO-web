using Microsoft.AspNetCore.Mvc;
using OpenKO.Web.Db;
using OpenKO.Web.Db.Entities.Game;

namespace OpenKO.Web.Endpoints.Accounts;

public class RegisterAccountEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app) =>
        app.MapPost(
            "/register",
            async (
                [FromBody] RegisterAccountRequest request,
                [FromServices] KnightOnlineDbContext dbContext,
                CancellationToken cancellationToken
            ) =>
            {
                var userCheck = dbContext.TbUsers.Any(x => x.StrAccountId == request.Username);

                if (userCheck)
                {
                    return Results.Conflict(new { Message = "Username already exists." });
                }

                var user = new TbUser
                {
                    StrAccountId = request.Username,
                    StrPasswd = request.Password,
                    StrAuthority = 1,
                    PremiumExpire = DateTime.Today,
                };

                await dbContext.TbUsers.AddAsync(user, cancellationToken);
                await dbContext.SaveChangesAsync(cancellationToken);
                return Results.Created($"/accounts/{request.Username}", new { request.Username });
            }
        );
}

public record RegisterAccountRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}
