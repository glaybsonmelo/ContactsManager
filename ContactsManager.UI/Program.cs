using Entities;
using Microsoft.EntityFrameworkCore;
using RespositoryContracts;
using ServiceContracts;
using Services;
using Repositories;
using CRUDExample;
using CRUDExample.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureServices(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
} else
{
    app.UseExceptionHandler("/Error");
    app.UseExceptionHandlingMiddleware();
}
app.UseHsts();
app.UseHttpsRedirection();

if (app.Environment.IsEnvironment("Test") == false) {
    //Rotativa executable (for convert view into pdf)
    Rotativa.AspNetCore.RotativaConfiguration
        .Setup("wwwroot", wkhtmltopdfRelativePath: "Rotativa");
}



app.UseStaticFiles();
app.UseRouting(); // Identifying action method based on route
app.UseAuthentication(); //Reading identity cookie
app.UseAuthorization(); // Validates access permitions of the user
app.MapControllers(); // Execute the filter pipeline (actino + filters)

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/"
    );
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action}/{id?}"
    );
});

app.Run();

public partial class Program { } // Make the auto-generated program accessible programmatically