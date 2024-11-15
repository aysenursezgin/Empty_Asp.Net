var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "Default",
    pattern: "{controller}/{action}"
    );

app.Run();
