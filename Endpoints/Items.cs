using Microsoft.AspNetCore.Mvc;

namespace GodheadAPI.Endpoints
{
    public class Items(WebApplication app)
    {
        public async Task GetAllItems()
        {
            app.MapGet("/items", () =>
            {
                // return items
            })
            .WithName("GetAllItems")
            .WithOpenApi();
        }
    }
}
