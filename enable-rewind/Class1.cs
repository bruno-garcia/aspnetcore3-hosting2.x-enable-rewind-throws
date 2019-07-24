using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.Internal;

public static class Class1
{
    public static void EnableRewind(this IApplicationBuilder app)
    {
        app.Use(async (context, next) =>
        {
            context.Request.EnableRewind();
            await next();
        });
    }
}
