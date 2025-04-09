namespace OrderService.Api.Middlewares;

public class ApiGatewayRestrictionMiddleware
{
    private readonly RequestDelegate _next;

    public ApiGatewayRestrictionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var origin = context.Request.Headers["Origin"].ToString();
        if (!string.IsNullOrEmpty(origin) && !origin.Contains("https://localhost:6000"))
        {
            context.Response.StatusCode = StatusCodes.Status403Forbidden;
            await context.Response.WriteAsync("Access denied. Only API Gateway is allowed.");
            return;
        }

        await _next(context);
    }
}
